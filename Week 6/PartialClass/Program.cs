namespace PartialClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Application
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp.FirstName = "goshko";
            emp.LastName = "peshkov";
            emp.Salary = 1000;
            emp.Bonus = 200;
            Console.WriteLine(emp.CalculateAllIncome());
        }
    }
}
