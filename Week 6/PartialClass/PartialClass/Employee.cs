namespace PartialClass
{
    /// <summary>
    /// Partial class employee.
    /// </summary>
    public partial class Employee
    {
        /// <summary>
        /// Gets or sets employee first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets employee last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or set employee salaray.
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// Gets or sets employee position.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets the employee bonus.
        /// </summary>
        public decimal Bonus { get; set; }

        /// <summary>
        /// Partial method print.
        /// </summary>
        partial void Print();
    }
}
