namespace DungeonsAndLizards
{
    public class Hero : Characters
    {
        public Hero(string name, string @class, int health, int mana, int manaRegenerationRate)
        {
            this.Name = name;
            this.Class = @class;
            this.Health = new Health(health);
            this.Mana = new Mana(mana);
            this.ManaRegenerationRate = manaRegenerationRate;
            this.MaxHealth = new Health(health);
            this.MaxMana = new Mana(mana);
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
            if (this.Mana.Value + manaPoints < this.MaxMana.Value && this.Mana.Value + this.ManaRegenerationRate < this.MaxMana.Value)
            {
                this.Mana.Value += manaPoints + this.ManaRegenerationRate;
            }
            else
            {
                this.Mana.Value = this.MaxMana.Value;
            }
        }
    }
}
