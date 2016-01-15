namespace LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CategoryWithProduct
    {
        public string CategoryName { get; set; }

        public List<string> ProductNames { get; set; }

        public int CategoryId { get; set; }
    }
}
