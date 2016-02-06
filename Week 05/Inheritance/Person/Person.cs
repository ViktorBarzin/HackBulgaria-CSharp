namespace Person
{
    /// <summary>
    /// Class Person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="gender">Sets the gender field.</param>
        public Person(string gender)
        {
            this.Gender = gender;
            this.DayiyStuff = "person stuff";
        }

        /// <summary>
        /// Gets or sets the <![CDATA[DayliStuff]]>.
        /// </summary>
        /// <value>Protected setter.</value>
        public string DayiyStuff { get; protected set; }

        /// <summary>
        /// Gets or sets the Gender.
        /// </summary>
        /// <value>Protected setter.</value>
        public string Gender { get; protected set; }

        /// <summary>
        /// Overrides ToString() method for Person class.
        /// </summary>
        /// <returns>Person object as String.</returns>
        public override string ToString()
        {
            return string.Format("I am {0} and {1} every day!", this.Gender, this.DayiyStuff);
        }
    }
}
