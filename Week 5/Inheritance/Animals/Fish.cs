using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Fish : Animals
    {
        public override void Move()
        {
            Console.Write("Fish ");
            base.Move();
        }

        public override void Eat()
        {
            Console.Write("Fish");
            base.Eat();
        }

        public override void GiveBirth()
        {
            Console.Write("Fish ");
            base.GiveBirth();
        }
    }
}
