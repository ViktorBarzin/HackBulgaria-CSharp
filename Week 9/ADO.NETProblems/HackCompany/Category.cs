namespace HackCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Category
    {
        public Category(string code, string name)
        {
            this.Code = code;
            this.Name = name; 
        }

        public string Code { get; set; }

        public string Name { get; set; }
    }
}
