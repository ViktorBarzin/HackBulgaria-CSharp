namespace Animals
{
    using System;

    public class Reptiles : Animals, ILandAnimals
    {
        public int Temp { get; set; }

        public override string Greet()
        {
            return string.Format("I am a Reptile !");
        }

        public override void Move()
        {
            Console.Write("Reptile ");
            base.Move();
        }

        public override void Eat()
        {
            Console.Write("Reptile");
            base.Eat();
        }

        public override void GiveBirth()
        {
            Console.Write("Reptile ");
            base.GiveBirth();
        }
    }
}
