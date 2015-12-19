using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Reptiles : Animals, ILandAnimals
    {
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

        public int Temp { get; set; }
    }
}
