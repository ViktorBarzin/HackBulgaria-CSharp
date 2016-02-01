namespace HackCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Order
    {
        public Order(int id, DateTime date, int customerId, double totalPrice)
        {
            this.Id = id;
            this.Date = date;
            this.CustomerId = customerId;
            this.TotalPrice = totalPrice;
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int CustomerId { get; set; }

        public double TotalPrice { get; set; }
    }
}
