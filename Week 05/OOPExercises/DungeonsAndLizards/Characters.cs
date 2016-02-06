namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Abstract class Characters.
    /// </summary>
    public abstract class Characters
    {
        /// <summary>
        /// Gets or sets the Name property.
        /// </summary>
        /// <value>Protected setter.</value>
        public string Name { get; protected set; }

        /// <summary>
        /// Gets or sets the Class property.
        /// </summary>
        /// <value>Protected setter.</value>
        public string Class { get; protected set; }

        /// <summary>
        /// Gets or sets the Health property of a Character.
        /// </summary>
        /// <value>Protected setter.</value>
        public Health Health { get; protected set; }

        /// <summary>
        /// Gets or sets the <![CDATA[Mana]]> property of a Character.
        /// </summary>
        /// <value>Protected setter.</value>
        public Mana Mana { get; protected set; }

        /// <summary>
        /// Gets or sets Weapon for a Character.
        /// </summary>
        /// <value>Must be a Weapon type object.</value>
        public Weapon Weapon { get; set; }

        /// <summary>
        /// Gets or sets the Spell for a Character.
        /// </summary>
        /// <value>Must be Spell type object.</value>
        public Spell Spell { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Character has an instance of the weapon class equipped.
        /// </summary>
        /// <value>Boolean type.</value>
        public bool HasWeapon { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Character has an instance of the spell class learned.
        /// </summary>
        /// <value>Boolean type.</value>
        public bool HasSpell { get; set; }

        /// <summary>
        /// Gets or sets the max health for a Character.
        /// </summary>
        /// <value>Set in the constructor.</value>
        public Health MaxHealth { get; protected set; }

        /// <summary>
        /// Gets or sets the max <![CDATA[mana]]> for a Character.
        /// </summary>
        /// <value>Set in the constructor.</value>
        public Mana MaxMana { get; protected set; }

        /// <summary>
        /// Gets or sets the current location.
        /// </summary>
        /// <value>KeyValuePair of integers.Consider matrix size.</value>
        public KeyValuePair<int, int> CurrentPosition { get; set; }

        /// <summary>
        /// Gets Character health.
        /// </summary>
        /// <returns>Character Health property.</returns>
        public Health GetHealth()
        {
            return this.Health;
        }

        /// <summary>
        /// Gets Character <![CDATA[mana]]>.
        /// </summary>
        /// <returns>Character <![CDATA[Mana]]> property.</returns>
        public Mana GetMana()
        {
            return this.Mana;
        }

        /// <summary>
        /// Checks if Character's health is positive.
        /// </summary>
        /// <returns>True if Hero Health is bigger than 0.</returns>
        public bool IsAlive()
        {
            return this.Health.Value > 0;
        }

        /// <summary>
        /// Checks if Character has a spell and has enough <![CDATA[mana]]> to cast it.
        /// </summary>
        /// <param name="spell">Spell to cast.</param>
        /// <returns>True if Character has the spell and has <![CDATA[mana]]> for it.</returns>
        public bool CanCast(Spell spell)
        {
            if (!this.HasSpell)
            {
                Console.WriteLine("ERROR: Spell {0} is not equiped!", spell.Name);
                return false;
            }

            if (this.Mana.Value < spell.ManaCost)
            {
                Console.WriteLine("ERROR: You dont have enough mana to cast {0}", spell.Name);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Reduces Character's health by value.
        /// </summary>
        /// <param name="damage">Value to reduce Character's health.</param>
        public void TakeDamage(float damage)
        {
            if (this.Health.Value > damage)
            {
                this.Health.Value -= (int)Math.Floor(damage);
            }
            else
            {
                this.Health.Value = 0;
            }
        }

        /// <summary>
        /// Heals Character by value.
        /// </summary>
        /// <param name="healingPoints">Healing value to take.</param>
        /// <returns>True if Character is alive.</returns>
        public bool TakeHealing(int healingPoints)
        {
            if (!this.IsAlive())
            {
                return false;
            }

            if (this.Health.Value + healingPoints > this.MaxHealth.Value)
            {
                this.Health.Value = this.MaxHealth.Value;
            }
            else
            {
                this.Health.Value += healingPoints;
            }

            return true;
        }

        /// <summary>
        /// Character attacks with weapon if one is equipped.
        /// </summary>
        /// <param name="weapon">Weapon to attack with.</param>
        /// <returns>The damage dealt by the weapon.</returns>
        public int Attack(Weapon weapon)
        {
            return this.Weapon == weapon ? this.Weapon.Damage : 0;
        }

        /// <summary>
        /// Character attacks with spell if one is learned.
        /// </summary>
        /// <param name="spell">Spell to attack with.</param>
        /// <returns>The damage dealt by the spell.</returns>
        public int Attack(Spell spell)
        {
            if (!this.CanCast(spell))
            {
                return 0;
            }

            return this.Spell.Damage;
        }

        /// <summary>
        /// Equips a weapon to the Character.
        /// </summary>
        /// <param name="weapon">Weapon to equip.</param>
        public void Equip(Weapon weapon)
        {
            if (this.HasWeapon)
            {
                return;
            }

            this.HasWeapon = true;
            this.Weapon = weapon;
        }

        /// <summary>
        /// Learns a spell.
        /// </summary>
        /// <param name="spell">Spell to learn.</param>
        public void Learn(Spell spell)
        {
            this.HasSpell = true;
            this.Spell = spell;
        }
    }
}
