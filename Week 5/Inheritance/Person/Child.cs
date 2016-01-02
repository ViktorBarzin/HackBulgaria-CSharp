namespace Person
{
    /// <summary>
    /// Class Child.
    /// </summary>
    public class Child : Person
    {
        /// <summary>
        /// Toy field.
        /// </summary>
        private Toy toy = new Toy();

        /// <summary>
        /// Initializes a new instance of the <see cref="Child"/> class.
        /// </summary>
        /// <param name="gender">Set the gender field.</param>
        public Child(string gender) : base(gender)
        {
            this.DayiyStuff = "play";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Child"/> class.
        /// </summary>
        /// <param name="gender">Set the gender field.</param>
        /// <param name="toy">Sets the Toy field.</param>
        public Child(string gender, Toy toy) : base(gender)
        {
            this.DayiyStuff = "play";
            this.toy = toy;
        }
    }
}
