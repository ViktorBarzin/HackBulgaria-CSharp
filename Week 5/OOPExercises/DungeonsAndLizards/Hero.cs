namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Hero : Characters
    {
        public Hero(string name, string @class, int health, int mana, int manaRegenerationRate)
        {
            this.Name = name;
            this.Class = @class;
            this.Health = health;
            this.Mana = mana;
            this.ManaRegenerationRate = manaRegenerationRate;
            this.MaxHealth = health;
            this.MaxMana = mana;
            this.HasSpell = false;
            this.HasWeapon = false;
        }

        public int ManaRegenerationRate { get; protected set; }

        public string KnownAs()
        {
            return string.Format("{0} the {1}", this.Name, this.Class);
        }

        public void TakeMana(int manaPoints)
        {
            if (this.Mana + manaPoints < this.MaxMana && this.Mana + this.ManaRegenerationRate < this.MaxMana)
            {
                this.Mana += manaPoints + this.ManaRegenerationRate;
            }
            else
            {
            this.Mana = this.MaxMana;
            }
        }
    }
}
