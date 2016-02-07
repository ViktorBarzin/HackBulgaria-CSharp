namespace TicketSystem
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    // TODO : seats as separte table if needed
    public class DbTrain
    {
        private readonly TicketSystemContainer context;

        public DbTrain(TicketSystemContainer context)
        {
            this.context = context;
        }

        public IEnumerable<Train> GetAllTrains()
        {
            return this.context.TrainSet;
        }

        public bool Addtrain(Train train)
        {
            try
            {
                this.context.TrainSet.Add(train);
                this.context.SaveChanges();
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool DeleteTrain(Train train)
        {
            try
            {
                // TODO : throwing and catching exception?
                if (!this.context.TrainSet.Contains(train))
                {
                    throw new ArgumentException("Databse does not containt specified train");
                }

                this.context.TrainSet.Remove(train);
                this.context.SaveChanges();
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool EditTrain(Train train, int id)
        {
            try
            {
                if (!this.context.TrainSet.Contains(train))
                {
                    Console.WriteLine("Train not in database");
                    return false;
                }

                // TODO : check if train id already exists if sql exception does not cover that
                this.context.TrainSet.FirstOrDefault(x => x.Id == train.Id).Id = id;
                this.context.SaveChanges();
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool EdinTrain(Train train, int seats)
        {
            try
            {
                if (!this.context.TrainSet.Contains(train))
                {
                    Console.WriteLine("Train not in database");
                    return false;
                }
                if (this.context.TrainSet.FirstOrDefault(x => x.Id == train.Id).Seats != seats)
                {
                    this.context.TrainSet.FirstOrDefault(x => x.Id == train.Id).Seats = seats;
                    this.context.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool EdinTrain(Train train, string description)
        {
            try
            {
                if (!this.context.TrainSet.Contains(train))
                {
                    Console.WriteLine("Train not in database");
                    return false;
                }
                if (this.context.TrainSet.FirstOrDefault(x => x.Id == train.Id).Description != description)
                {
                    this.context.TrainSet.FirstOrDefault(x => x.Id == train.Id).Description = description;
                    this.context.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
