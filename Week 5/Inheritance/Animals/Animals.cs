namespace Animals
{
    using System;

    /// <summary>
    /// Abstract class Animals.
    /// </summary>
    public abstract class Animals
    {
        /// <summary>
        /// Virtual greet method.
        /// </summary>
        /// <returns>String greet from animal.</returns>
        public virtual string Greet()
        {
            return string.Format("Greet from animal");
        }

        /// <summary>
        /// Virtual Move method.
        /// </summary>
        public virtual void Move()
        {
            Console.WriteLine(" move");
        }

        /// <summary>
        /// Virtual Eat method.
        /// </summary>
        public virtual void Eat()
        {
            Console.WriteLine(" eat");
        }

        /// <summary>
        /// Virtual GiveBirth method.
        /// </summary>
        public virtual void GiveBirth()
        {
            Console.WriteLine(" give birth");
        }
    }
}
