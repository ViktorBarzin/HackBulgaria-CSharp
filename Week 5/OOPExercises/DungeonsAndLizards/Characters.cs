namespace DungeonsAndLizards
{
    using System;

    public abstract class Characters
    {
        public string Name { get; protected set; }

        public string Class { get; protected set; }

        public Health Health { get; protected set; }

        public Mana Mana { get; protected set; }

        public Weapon Weapon { get; set; }

        public Spell Spell { get; set; }

        public bool HasWeapon { get; set; }

        public bool HasSpell { get; set; }

        public Health MaxHealth { get; protected set; }

        public Mana MaxMana { get; protected set; }

        public Health GetHealth()
        {
            return this.Health;
        }

        public Mana GetMana()
        {
            return this.Mana;
        }

        public bool IsAlive()
        {
            return this.Health.Value > 0;
        }

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

        public int Attack(Weapon weapon)
        {
            return this.Weapon == weapon ? this.Weapon.Damage : 0;
        }

        public int Attack(Spell spell)
        {
            if (!this.CanCast(spell))
            {
                return 0;
            }

            return this.Spell.Damage;
        }

        public void Equip(Weapon weapon)
        {
            if (this.HasWeapon)
            {
                return;
            }

            this.HasWeapon = true;
            this.Weapon = weapon;
        }

        public void Learn(Spell spell)
        {
            if (this.HasSpell)
            {
                return;
            }

            this.HasSpell = true;
            this.Spell = spell;
        }
    }
}
