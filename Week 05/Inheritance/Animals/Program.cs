namespace Animals
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Application class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method.
        /// </summary>
        public static void Main()
        {
            List<Animals> animals = new List<Animals> { new Shark(), new Owl(), new Dog(), new Bird() };

            foreach (var variable in animals)
            {
                Console.WriteLine(variable.Greet());
            }

            // TODO : foreach animals
        }
    }
}
