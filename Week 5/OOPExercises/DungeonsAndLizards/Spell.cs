namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Spell
    {
        public Spell(string name, int damage, int manaCost, int castRange)
        {
            this.Name = name;
            this.Damage = damage;
            this.ManaCost = manaCost;
            this.CastRange = castRange;
        }

        public string Name { get; protected set; }

        public int Damage { get; protected set; }

        public int ManaCost { get; protected set; }

        public int CastRange { get; protected set; }
    }
}
