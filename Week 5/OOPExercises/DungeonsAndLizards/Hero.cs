namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Hero
    {
        public Hero(string name, string @class, int health, int mana, int manaRegenerationRate)
        {
            this.Name = name;
            this.Class = @class;
            this.Health = health;
            this.Mana = mana;
            this.ManaRegenerationRate = manaRegenerationRate;
        }

        public string Name { get; protected set; }

        public string Class { get; protected set; }

        public int Health { get; protected set; }

        public int Mana { get; protected set; }

        public int ManaRegenerationRate { get; protected set; }

        public string KnownAs()
        {
            return string.Format("{0} the {1}", this.Name, this.Class);
        }

        // GetHealth() and GetMana() and IsAlive() and CanCast()

        public int GetHealth()
        {
            return this.Health;
        }

        public int GetMana()
        {
            return this.Mana;
        }

        public bool IsAlive()
        {
            return this.Health > 0;
        }

        public bool CanCast()
        {
            // implement spell class
            throw new NotImplementedException();
        }

    }
}
