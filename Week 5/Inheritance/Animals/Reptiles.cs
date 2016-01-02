namespace Animals
{
    using System;

    /// <summary>
    /// Class Reptiles.
    /// </summary>
    public class Reptiles : Animals, ILandAnimals
    {
        /// <summary>
        /// Gets or sets the temperature for a Reptile.
        /// </summary>
        /// <value>No value restrictions.</value>
        public int Temperature { get; set; }

        /// <summary>
        /// Overrides Greet() method.
        /// </summary>
        /// <returns>String greet from Reptile.</returns>
        public override string Greet()
        {
            return string.Format("I am a Reptile !");
        }

        /// <summary>
        /// Overrides Move() method.
        /// </summary>
        public override void Move()
        {
            Console.Write("Reptile ");
            base.Move();
        }

        /// <summary>
        /// Overrides Eat() method.
        /// </summary>
        public override void Eat()
        {
            Console.Write("Reptile");
            base.Eat();
        }

        /// <summary>
        /// Overrides GiveBirth() method.
        /// </summary>
        public override void GiveBirth()
        {
            Console.Write("Reptile ");
            base.GiveBirth();
        }
    }
}
