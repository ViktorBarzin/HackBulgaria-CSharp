namespace TicketSystem
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    public class DbSchedule
    {
        private readonly TicketSystemContainer context;

        public DbSchedule(TicketSystemContainer context)
        {
            this.context = context;
        }

        public IEnumerable<Schedule> DisplaySchedule()
        {
            return this.context.ScheduleSet;
        }

        public bool AddTrip(Schedule schedule)
        {
            try
            {
                this.context.ScheduleSet.Add(schedule);
                this.context.SaveChanges();
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        // TODO : edit a trip

        public IEnumerable<Schedule> AllTripsFrom(City a, City b)
        {
            return this.context.ScheduleSet.Where(x => x.StartCity.ToString().Equals(a.ToString()) && x.EndCity.ToString().Equals(b.ToString()));
        }
    }
}
