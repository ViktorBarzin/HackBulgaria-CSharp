namespace DungeonsAndLizards
{
    /// <summary>
    /// Class Enemy.
    /// </summary>
    public class Enemy : Characters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Enemy"/> class.
        /// </summary>
        /// <param name="health">Sets Enemy health.</param>
        /// <param name="mana">Sets Enemy <![CDATA[mana]]>.</param>
        /// <param name="damage">Sets enemy damage.</param>
        public Enemy(int health, int mana, int damage)
        {
            this.Health = new Health(health);
            this.Mana = new Mana(mana);
            this.Damage = damage;
        }

        /// <summary>
        /// Gets or sets the damage property.
        /// </summary>
        /// <value>Protected setter in constructor as well.</value>
        public int Damage { get; protected set; }
    }
}