namespace DungeonsAndLizards
{
    /// <summary>
    /// Class Weapon.
    /// </summary>
    public class Weapon
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Weapon"/> class.
        /// </summary>
        /// <param name="name">Sets the Weapon name.</param>
        /// <param name="damage">Sets the Weapon damage.</param>
        public Weapon(string name, int damage)
        {
            this.Name = name;
            this.Damage = damage;
        }

        /// <summary>
        /// Gets the Weapon name.
        /// </summary>
        /// <value>Name is set in the constructor.</value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the Weapon damage.
        /// </summary>
        /// <value>Damage is set in the constructor.</value>
        public int Damage { get; private set; }
    }
}
