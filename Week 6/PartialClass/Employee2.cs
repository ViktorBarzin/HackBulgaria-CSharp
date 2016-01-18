using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Employee
    {
        partial void Print()
        {
            Console.Write(string.Format("{0} {1}", this.FirstName, this.LastName));
        }

        public decimal CalculateAllIncome()
        {
            this.Print();
            return this.Salary + this.Bonus;
        }

        public decimal CalculateBalance()
        {
            return (this.Salary + this.Bonus) * (decimal)0.8;
        }
    }
}
