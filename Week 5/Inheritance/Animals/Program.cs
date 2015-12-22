namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
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
