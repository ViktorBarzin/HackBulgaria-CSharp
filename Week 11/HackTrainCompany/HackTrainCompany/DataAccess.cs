using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    using HackTrainCompany;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography;
    using System.Windows;

    public class DataAccess
    {
        private const string DbDoestNotContain = "Database does not contain the specified ";

        private static HackTrainCompanyEntities Context { get; } = new HackTrainCompanyEntities();

        public static void SaveChanges()
        {
            Context.SaveChanges();
        }

        // City Logic
        public static ICollection<CitySet> GetAllCities()
        {
            var cities = Context.CitySet.ToList();
            return cities;
        }

        public static bool AddCity(CitySet city)
        {
            try
            {
                Context.CitySet.Add(city);
                Context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        public static bool DeleteCity(CitySet city)
        {
            try
            {
                Context.CitySet.Remove(city);
                Context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        // Train logic
        public static ICollection<TrainSet> GetAllTrains()
        {
            return Context.TrainSet.ToList();
        }

        public static bool AddTrain(TrainSet train)
        {
            try
            {
                Context.TrainSet.Add(train);
                Context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        public static bool DeleteTrain(TrainSet train)
        {
            try
            {
                //if (!Context.TrainSet.Contains(train))
                //{
                //    throw new ArgumentException(string.Format(DbDoestNotContain + "train!"));
                //}

                Context.TrainSet.Remove(train);
                Context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        public static bool EditTrain(int oldTrainId,TrainSet newTrain)
        {
            try
            {
                TrainSet original = Context.TrainSet.FirstOrDefault(x => x.Id == oldTrainId);

                if (original == null)
                {
                    return false;
                }

                original.IsFree = newTrain.IsFree;
                original.Description = newTrain.Description;
                original.Seats = newTrain.Seats;
                Context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        // Schedule logic
        public static ICollection<ScheduleSet> GetFullSchedule()
        {
            return Context.ScheduleSet.ToList();
        }

        public static bool AddTrip(ScheduleSet trip)
        {
            try
            {
                // TODO : check if C# joins correctly
                if (!Context.TrainSet.Contains(trip.TrainSet))
                {
                    throw new ArgumentException(string.Format(DbDoestNotContain + "train!"));
                }

                // TODO : make trains not free only at the specified time, not all the time
                //var trainsWithSchedule = Context.ScheduleSet.Where(x => x.TrainId == trip.TrainId).Where(y => y.)
                //bool IsFree = true;
                //if (trainsWithSchedule.Count != 1)
                //{
                //    for (int i = 0; i < trainsWithSchedule.Count; i++)
                //    {
                //        trainsWithSchedule
                //    }
                //}

                if (trip.TrainSet.IsFree)
                {
                    trip.TrainSet.IsFree = false;
                    Context.ScheduleSet.Add(trip);
                    Context.SaveChanges();
                    return true;
                }

                throw new ArgumentException("Train is not free at the selected period");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        public static bool DeleteTrip(ScheduleSet trip)
        {
            try
            {
                if (!Context.ScheduleSet.Contains(trip))
                {
                    throw new ArgumentException(string.Format(DbDoestNotContain + "trip"));
                }

                Context.ScheduleSet.Remove(trip);
                Context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        // User logic
        public static ICollection<UserSet> GetAllUsers()
        {
            return Context.UserSet.ToList();
        }

        public static bool AddUser(UserSet user)
        {
            try
            {
                if (Context.UserSet.Where(x => x.Username == user.Username).ToList().Count > 0
                || Context.UserSet.Where(x => x.Email == user.Email).ToList().Count > 0
                || Context.UserSet.Where(x => user.CreditCardNumberHash != null && x.CreditCardNumberHash == user.CreditCardNumberHash).ToList().Count > 0
                || Context.UserSet.Where(x => user.DiscountCardId != null && x.DiscountCardId == user.DiscountCardId).ToList().Count > 0)
                {
                    throw new ArgumentException("User information with the same data already exists");
                }

                if (user.Username != null
                    && user.Email != null
                    && user.PasswordHash != null
                    )
                {
                    Context.UserSet.Add(user);
                    Context.SaveChanges();
                    return true;
                }

                throw new ArgumentException("Username, email and password must not be empty!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        public static bool Login(UserSet user)
        {
            var userByUsername = Context.UserSet.FirstOrDefault(x => x.Username == user.Username);
            if (userByUsername != null)
            {
                return userByUsername.PasswordHash == user.PasswordHash;
            }

            var userByEmail = Context.UserSet.FirstOrDefault(x => x.Email == user.Email);
            return userByEmail != null && userByEmail.PasswordHash == user.PasswordHash;
        }

    }
}
