namespace Animals
{
    using System;

    /// <summary>
    /// Class Bird.
    /// </summary>
    public class Bird : Animals, ILandAnimals
    {
        /// <summary>
        /// Overrides base Greet() method.
        /// </summary>
        /// <returns>String Greet.</returns>
        public override string Greet()
        {
            return string.Format("I am a bird !");
        }

        /// <summary>
        /// Overrides Move() method.
        /// </summary>
        public override void Move()
        {
            Console.Write("Bird ");
            base.Move();
        }

        /// <summary>
        /// Overrides Eat() method.
        /// </summary>
        public override void Eat()
        {
            Console.Write("Bird ");
            base.Eat();
        }

        /// <summary>
        /// Overrides GiveBirth() method.
        /// </summary>
        public override void GiveBirth()
        {
            Console.WriteLine("Bird ");
            base.GiveBirth();
        }

        /// <summary>
        /// MakeNest method.
        /// </summary>
        public void MakeNest()
        {
            Console.WriteLine("Make nest");
        }
    }
}
