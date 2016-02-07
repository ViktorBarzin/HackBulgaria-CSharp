namespace TicketSystem
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    public class DbCity
    {
        private readonly TicketSystemContainer context;

        public DbCity(TicketSystemContainer context)
        {
           this.context = context;
        }

        public IEnumerable<City> GetAllCities()
        {
            return this.context.CitySet;
        }

        public bool AddCity(City city)
        {
            try
            {
                this.context.CitySet.Add(city);
                this.context.SaveChanges();
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool DeleteCity(City city)
        {
            try
            {
                if (!this.context.CitySet.Contains(city))
                {
                    throw new ArgumentException(string.Format("The database does not contain {0} city", city));
                }

                this.context.CitySet.Remove(city);
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
