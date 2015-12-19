using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Crocodile : Animals,ILandAnimals
    {
        public override string Greet()
        {
            return string.Format("krok krok");
        }
    }
}
