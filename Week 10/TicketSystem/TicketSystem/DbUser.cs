using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    using System.Data.SqlClient;

    public class DbUser
    {
        private readonly TicketSystemContainer context;

        private User user;

        public DbUser(User user, TicketSystemContainer context)
        {
            this.context = context;
            this.user = user;
        }

        // TODO : double check
        public bool BuyTicket(Ticket ticket)
        {
            if (!this.context.TicketSet.Contains(ticket))
            {
                throw new ArgumentException("Ticket not available");
            }

            if (this.context.TicketSet.FirstOrDefault(x => x.Id == ticket.Id).UserSoldTo == null)
            {
                throw new ArgumentException("Ticket is sold");
            }

            try
            {
                this.context.TicketSet.FirstOrDefault(x => x.Id == ticket.Id).UserSoldTo = user.Id;
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
