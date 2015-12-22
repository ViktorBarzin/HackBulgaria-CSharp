namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Weapon
    {
        public Weapon(string name, int damage)
        {
            this.Name = name;
            this.Damage = damage;
        }

        public string Name { get; private set; }

        public int Damage { get; private set; }
    }
}
