namespace Animals
{
    using System;

    /// <summary>
    /// Class Fish.
    /// </summary>
    public class Fish : Animals
    {
        /// <summary>
        /// Overrides Move() method.
        /// </summary>
        public override void Move()
        {
            Console.Write("Fish ");
            base.Move();
        }

        /// <summary>
        /// Overrides Eat() method.
        /// </summary>
        public override void Eat()
        {
            Console.Write("Fish");
            base.Eat();
        }

        /// <summary>
        /// Overrides GiveBirth() method.
        /// </summary>
        public override void GiveBirth()
        {
            Console.Write("Fish ");
            base.GiveBirth();
        }
    }
}
