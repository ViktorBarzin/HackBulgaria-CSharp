namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Characters
    {
        public string Name { get; protected set; }

        public string Class { get; protected set; }

        public int Health { get; protected set; }

        public int Mana { get; protected set; }

        public Weapon Weapon { get; protected set; }

        public Spell Spell { get; protected set; }

        public bool HasWeapon { get; set; }

        protected bool HasSpell { get; set; }

        protected int MaxHealth { get; set; }

        protected int MaxMana { get; set; }

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

        public bool CanCast(Spell spell)
        {
            if (!HasSpell)
            {
                Console.WriteLine("ERROR: Spell {0} is not equiped!", spell.Name);
                return false;
            }

            if (this.Mana < spell.ManaCost)
            {
                Console.WriteLine("ERROR: You dont have enough mana to cast {0}", spell.Name);
                return false;
            }

            return true;
        }

        public void TakeDamage(float damage)
        {
            if (this.Health > damage)
            {
                this.Health -= (int)Math.Floor(damage);
            }
            else
            {
                this.Health = 0;
            }
        }

        public bool TakeHealing(int healingPoints)
        {
            if (!this.IsAlive())
            {
                return false;
            }

            if (this.Health + healingPoints > this.MaxHealth)
            {
                this.Health = this.MaxHealth;
            }
            else
            {
                this.Health += healingPoints;
            }

            return true;
        }

        public int Attack(Weapon weapon)
        {
            return this.Weapon == weapon ? this.Weapon.Damage : 0;
        }

        public int Attack(Spell spell)
        {
            if (!CanCast(spell))
            {
                return -1;
            }

            return this.Spell.Damage;
        }

        public void Equip(Weapon weapon)
        {
            if (HasWeapon)
            {
                return;
            }

            this.HasWeapon = true;
            this.Weapon = weapon;
        }

        public void Learn(Spell spell)
        {
            if (HasSpell)
            {
                return;
            }

            this.HasSpell = true;
            this.Spell = spell;
        }
    }
}
