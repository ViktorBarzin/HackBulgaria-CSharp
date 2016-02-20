using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography;

    public static class DataAccess
    {
        private const string DbDoestNotContain = "Database does not contain the specified ";

        public static HackTrainCompanyEntities Context = new HackTrainCompanyEntities();

        //static DataAccess()
        //{
        //    Context = new HackTrainCompanyEntities();
        //}

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
                Console.WriteLine(exception.Message);
                return false;
            }
        }

        public static bool DeleteCity(CitySet city)
        {
            try
            {
                if (!Context.CitySet.Contains(city))
                {
                    throw new ArgumentException(string.Format(DbDoestNotContain + "city"));
                }
                Context.CitySet.Remove(city);
                Context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
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
                Console.WriteLine(exception.Message);
                return false;
            }
        }

        public static bool DeleteTrain(TrainSet train)
        {
            try
            {
                if (!Context.TrainSet.Contains(train))
                {
                    throw new ArgumentException(string.Format(DbDoestNotContain + "train!"));
                }

                Context.TrainSet.Remove(train);
                Context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }
        }

        public static bool EditTrain(TrainSet train)
        {
            try
            {
                if (!Context.TrainSet.Contains(train))
                {
                    throw new ArgumentException(string.Format(DbDoestNotContain + "train!"));
                }

                var traintToEdit = Context.TrainSet.Find(train.Id);

                if (traintToEdit != null)
                {
                    Context.Entry(traintToEdit).CurrentValues.SetValues(train);
                    Context.SaveChanges();
                    return true;
                }

                throw new ArgumentException(string.Format(DbDoestNotContain + "train!"));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
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
                Console.WriteLine(exception.Message);
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
                Console.WriteLine(exception.Message);
                return false;
            }
        }

        // User logic
        public static bool AddUser(UserSet user)
        {
            try
            {
                if (Context.UserSet.Where(x => x.Username == user.Username).ToList().Count > 0
                || Context.UserSet.Where(x => x.Email == user.Email).ToList().Count > 0
                || Context.UserSet.Where(x => x.CreditCardNumberHash == user.CreditCardNumberHash).ToList().Count > 0
                || Context.UserSet.Where(x => x.TicketId == user.TicketId).ToList().Count > 0
                || Context.UserSet.Where(x => x.DiscountCardId == user.DiscountCardId).ToList().Count > 0)
                {
                    throw new ArgumentException("User information with the same data already exists");
                }
                if (user.Username != null 
                    && user.Email != null
                    && user.PasswordHash != null
                    && user.Salt != null)
                {
                    Context.UserSet.Add(user);
                    Context.SaveChanges();
                    return true;
                }

                throw new ArgumentException("User has fields who should not be empty!");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
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

        //private static byte[] HashPassword(string password,IEnumerable<byte> salt)
        //{
        //    return HashPassword(Encoding.UTF8.GetBytes(password), salt);
        //}

        //private static byte[] HashPassword(IEnumerable<byte> password, IEnumerable<byte> salt)
        //{
        //    byte[] saltedValue = password.Concat(salt).ToArray();

        //    return new SHA256Managed().ComputeHash(saltedValue);
        //}

        //public static bool ConfirmLogin(string username,string password)
        //{

        //    var user = Context.UserSet.FirstOrDefault(x => x.Username == username);
        //    if (user == null)
        //    {
        //        return false;
        //    }

        //    byte[] passwordToCheckHash = HashPassword(password, GetBytes(user.Salt));
        //    for (int i = 0; i < user.PasswordHash.Length; i++)
        //    {
        //        if (passwordToCheckHash[i] != user.PasswordHash[i])
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        //private static byte[] GetBytes(string str)
        //{
        //    byte[] bytes = new byte[str.Length * sizeof(char)];
        //    System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
        //    return bytes;
        //}
    }
}
