namespace Animals
{
    using System;

    public class Bird : Animals, ILandAnimals
    {
        public override string Greet()
        {
            return string.Format("I am a bird !");
        }

        public override void Move()
        {
            Console.Write("Bird ");
            base.Move();
        }

        public override void Eat()
        {
            Console.Write("Bird ");
            base.Eat();
        }

        public override void GiveBirth()
        {
            Console.WriteLine("Bird ");
            base.GiveBirth();
        }

        public void MakeNest()
        {
            Console.WriteLine("Make nest");
        }
    }
}
