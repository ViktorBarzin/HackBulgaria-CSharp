using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Owl : Bird,ILandAnimals
    {
        public override string Greet()
        {
            return string.Format("Buu-buu");
        }
    }
}
