namespace Animals
{
    public class Cat : Mammals
    {
        public new string Greet()
        {
            return string.Format("Meow");
        }
    }
}
