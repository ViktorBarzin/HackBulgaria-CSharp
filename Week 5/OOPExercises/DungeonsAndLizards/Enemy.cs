namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Enemy : Characters
    {
        public int Damage { get; protected set; }

        public Enemy(int health, int mana, int damage)
        {
            this.Health = new Health(health);
            this.Mana = new Mana(mana);
            // damage += weapon + spell damage
            this.Damage = damage;
        }
    }
}
