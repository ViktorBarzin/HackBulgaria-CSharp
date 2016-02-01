namespace HackCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Product
    {
        public Product(int id, string name, double price, string category)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Category = category;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Category { get; set; }
    }
}
