namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Animals> animals = new List<Animals> {new Shark(),new Owl(),new Dog(),new Bird()};

            foreach (var VARIABLE in animals)
            {
                Console.WriteLine(VARIABLE.Greet());
            }

            // TODO : foreach animals
        }
    }
}
