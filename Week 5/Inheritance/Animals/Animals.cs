namespace Animals
{
    using System;

    public abstract class Animals
    {
        public virtual string Greet()
        {
            return string.Format("Greet from animal");
        }

        public virtual void Move()
        {
            Console.WriteLine(" move");
        }

        public virtual void Eat()
        {
            Console.WriteLine(" eat");
        }

        public virtual void GiveBirth()
        {
            Console.WriteLine(" give birth");
        }
    }
}
