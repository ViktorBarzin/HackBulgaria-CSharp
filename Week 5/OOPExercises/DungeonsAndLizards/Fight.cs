namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class Fight.
    /// </summary>
    public class Fight
    {
        /// <summary>
        /// Hero instance to take part in the Fight.
        /// </summary>
        private readonly Hero hero;

        /// <summary>
        /// Enemy instance to take part in the fight.
        /// </summary>
        private readonly Enemy enemy;

        /// <summary>
        /// Map where the Fight takes place.
        /// </summary>
        private char[,] map;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fight"/> class.
        /// </summary>
        /// <param name="hero">Sets hero for the Fight.</param>
        /// <param name="enemy">Sets Enemy for the Fight.</param>
        /// <param name="map">Sets place where the Fight will take place.</param>
        public Fight(Hero hero, Enemy enemy, char[,] map)
        {
            this.hero = hero;
            this.enemy = enemy;
            this.map = map;
            this.Combat();
        }

        /// <summary>
        /// Prints the fight to the console.
        /// </summary>
        private void Combat()
        {
            Console.WriteLine("A fight has been started between {0}({1} health, {2} mana) and Enemy({3} health, {4} mana, {5} damage)", this.hero.Name, this.hero.Health.Value, this.hero.Mana.Value, this.enemy.Health.Value, this.enemy.Mana.Value, this.enemy.Damage);

            while (this.hero.Health.Value >= 0 && this.enemy.Health.Value >= 0)
            {
            }
        }
    }
}
