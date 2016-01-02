namespace Animals
{
    using System;

    /// <summary>
    /// Abstract class Mammals.
    /// </summary>
    public abstract class Mammals : Animals, ILandAnimals
    {
        /// <summary>
        /// Overrides Move() method.
        /// </summary>
        public override void Move()
        {
            Console.Write("Mammal ");
            base.Move();
        }

        /// <summary>
        /// Overrides Eat() method.
        /// </summary>
        public override void Eat()
        {
            Console.Write("Mammal");
            base.Eat();
        }

        /// <summary>
        /// Overrides GiveBirth() method.
        /// </summary>
        public override void GiveBirth()
        {
            Console.Write("Mammal ");
            base.GiveBirth();
        }

        /// <summary>
        /// Overrides Greet() method.
        /// </summary>
        /// <returns>String Greet from mammal.</returns>
        public override string Greet()
        {
            return string.Format("Greet from mammal !");
        }
    }
}
