namespace Person
{
    public class Adult : Person
    {
        private Child child;

        public Adult(string gender) : base(gender)
        {
            this.DayiyStuff = "go to work";
        }

        public Adult(string gender, Child child) : base(gender)
        {
            this.child = child;
            this.DayiyStuff = "go to work";
        }
    }
}
