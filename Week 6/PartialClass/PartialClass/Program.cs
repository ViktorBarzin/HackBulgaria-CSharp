namespace PartialClass
{
    using System;

    /// <summary>
    /// Application class.
    /// </summary>
    public class Application
    {
        /// <summary>
        /// Main method.
        /// </summary>
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
