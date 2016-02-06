namespace HackCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Customer
    {
        public Customer(int id,string name, string email, string address, int? discount)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Address = address;
            this.Discount = discount;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public int? Discount { get; set; }
    }
}
