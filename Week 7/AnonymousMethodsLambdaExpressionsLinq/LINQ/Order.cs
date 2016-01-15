namespace LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Order
    {
        public Order(int id, List<int> products, DateTime orderDate)
        {
            this.Id = id;
            this.Products = products;
            this.OrderDate = orderDate;
        }

        public int Id { get; set; }

        public List<int> Products { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
