using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Panda
    {
        public string Name { get;private set; }

        public List<Panda> Friends { get; set; } = new List<Panda>();


        public Panda(string name)
        {
            this.Name = name;
        }
    }
}
