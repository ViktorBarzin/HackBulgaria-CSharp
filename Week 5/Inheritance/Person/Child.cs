namespace Person
{
    public class Child : Person
    {
        private Toy toy = new Toy();

        public Child(string gender) : base(gender)
        {
            this.DayiyStuff = "play";
        }

        public Child(string gender, Toy toy) : base(gender)
        {
            this.DayiyStuff = "play";
            this.toy = toy;
        }
    }
}
