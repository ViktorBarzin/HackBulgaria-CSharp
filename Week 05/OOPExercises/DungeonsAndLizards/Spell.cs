namespace DungeonsAndLizards
{
    /// <summary>
    /// Class Spell.
    /// </summary>
    public class Spell
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Spell"/> class.
        /// </summary>
        /// <param name="name">Sets the name of the Spell.</param>
        /// <param name="damage">Sets the Spell damage.</param>
        /// <param name="manaCost">Sets Spell <![CDATA[mana]]> cost.</param>
        /// <param name="castRange">Sets Spell casting range.</param>
        public Spell(string name, int damage, int manaCost, int castRange)
        {
            this.Name = name;
            this.Damage = damage;
            this.ManaCost = manaCost;
            this.CastRange = castRange;
        }

        /// <summary>
        /// Gets or sets Spell name.
        /// </summary>
        /// <value>Value set in constructor.</value>
        public string Name { get; protected set; }

        /// <summary>
        /// Gets or sets Spell damage.
        /// </summary>
        /// <value>Value set in constructor.</value>
        public int Damage { get; protected set; }

        /// <summary>
        /// Gets or sets Spell <![CDATA[mana]]> cost.
        /// </summary>
        /// <value>Value set in constructor.</value>
        public int ManaCost { get; protected set; }

        /// <summary>
        /// Gets or sets Spell cast range.
        /// </summary>
        /// <value>Value set in constructor.</value>
        public int CastRange { get; protected set; }
    }
}
