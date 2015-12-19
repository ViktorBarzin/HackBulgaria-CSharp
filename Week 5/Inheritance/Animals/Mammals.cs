﻿namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Mammals : Animals, ILandAnimals
    {
        public override void Move()
        {
            Console.Write("Mammal ");
            base.Move();
        }

        public override void Eat()
        {
            Console.Write("Mammal");
            base.Eat();
        }

        public override void GiveBirth()
        {
            Console.Write("Mammal ");
            base.GiveBirth();
        }

        public override string Greet()
        {
            return string.Format("Greet from mammal !");
        }
    }
}
