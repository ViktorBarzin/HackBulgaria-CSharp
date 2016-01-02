namespace Person
{
    /// <summary>
    /// Class Adult.
    /// </summary>
    public class Adult : Person
    {
        /// <summary>
        /// Child type field.
        /// </summary>
        private Child child;

        /// <summary>
        /// Initializes a new instance of the <see cref="Adult"/> class.
        /// </summary>
        /// <param name="gender">Sets the gender property.</param>
        public Adult(string gender) : base(gender)
        {
            this.DayiyStuff = "go to work";
        }

        /// <summary>    
        /// Initializes a new instance of the <see cref="Adult"/> class.
        /// </summary>
        /// <param name="gender">Sets the gender field.</param>
        /// <param name="child">Set the Child field.</param>
        public Adult(string gender, Child child) : base(gender)
        {
            this.child = child;
            this.DayiyStuff = "go to work";
        }
    }
}
