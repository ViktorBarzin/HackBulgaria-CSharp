namespace DungeonsAndLizards
{
    /// <summary>
    /// Class Hero.
    /// </summary>
    public class Hero : Characters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hero"/> class.
        /// </summary>
        /// <param name="name">Sets Hero name.</param>
        /// <param name="class">Sets Hero class.</param>
        /// <param name="health">Sets Hero health and max health.</param>
        /// <param name="mana">Sets Hero mana and max mana.</param>
        /// <param name="manaRegenerationRate">Sets hero mana regeneration rate.</param>
        public Hero(string name = "John", string @class = "Jedi", int health = 100, int mana = 100, int manaRegenerationRate = 2)
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

        /// <summary>
        /// Gets or sets Hero Mana regeneration rate.
        /// </summary>
        /// <value>Value is set in the constructor.No game features to increase mana regeneration rate.</value>
        public int ManaRegenerationRate { get; protected set; }

        /// <summary>
        /// Returns Hero name and class.
        /// </summary>
        /// <returns>Returns a string of Hero's name and class properties.</returns>
        public string KnownAs()
        {
            return string.Format("{0} the {1}", this.Name, this.Class);
        }

        /// <summary>
        /// Increases Hero mana value.
        /// </summary>
        /// <param name="manaPoints">Value of mana the Hero will gain.</param>
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
