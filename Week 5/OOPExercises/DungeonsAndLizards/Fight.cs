namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Fight
    {
        private readonly Hero hero;
        private readonly Enemy enemy;
        private char[,] map;

        public Fight(Hero hero, Enemy enemy, char[,] map)
        {
            this.hero = hero;
            this.enemy = enemy;
            this.map = map;
            this.Combat();
        }

        private void Combat()
        {
            Console.WriteLine("A fight has been started between {0}({1} health, {2} mana) and Enemy({3} health, {4} mana, {5} damage)", this.hero.Name, this.hero.Health.Value, this.hero.Mana.Value, this.enemy.Health.Value, this.enemy.Mana.Value, this.enemy.Damage);

            while (this.hero.Health.Value >= 0 && this.enemy.Health.Value >= 0)
            {
            }
        }
    }
}
