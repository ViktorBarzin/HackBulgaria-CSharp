namespace Person
{
    public class Person
    {
        public Person(string gender)
        {
            this.Gender = gender;
            this.DayiyStuff = "person stuff";
        }

        public string DayiyStuff { get; protected set; }

        public string Gender { get; protected set; }

        public override string ToString()
        {
            return string.Format("I am {0} and {1} every day!", this.Gender, this.DayiyStuff);
        }
    }
}
