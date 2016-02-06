namespace PartialClass
{
    using System;

    /// <summary>
    /// Partial class Employee.
    /// </summary>
    public partial class Employee
    {
        /// <summary>
        /// Prints employe first name and last name to the console.
        /// </summary>
        partial void Print()
        {
            Console.Write(string.Format("{0} {1}", this.FirstName, this.LastName));
        }

        /// <summary>
        /// Calculates employee income.
        /// </summary>
        /// <returns>Salary + Bonus.</returns>
        public decimal CalculateAllIncome()
        {
            this.Print();
            return this.Salary + this.Bonus;
        }

        /// <summary>
        /// Calculates balance.
        /// </summary>
        /// <returns>Income without taxes.</returns>
        public decimal CalculateBalance()
        {
            return (this.Salary + this.Bonus) * (decimal)0.8;
        }
    }
}
