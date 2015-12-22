namespace Animals
{
    using System;

    public class Fish : Animals
    {
        public override void Move()
        {
            Console.Write("Fish ");
            base.Move();
        }

        public override void Eat()
        {
            Console.Write("Fish");
            base.Eat();
        }

        public override void GiveBirth()
        {
            Console.Write("Fish ");
            base.GiveBirth();
        }
    }
}
