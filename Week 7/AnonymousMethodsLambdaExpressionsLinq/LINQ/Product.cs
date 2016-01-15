namespace LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Product
    {
        public Product(string name, int id, int categoryId)
        {
            this.Name = name;
            this.Id = id;
            this.CategoryId = categoryId;
        }

        public string Name { get; set; }

        public int Id { get; set; }

        public int CategoryId { get; set; }
    }
}
