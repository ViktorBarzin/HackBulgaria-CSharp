namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Fight
    {
        private Hero hero;
        private Enemy enemy;
        private char[,] map;

        public Fight(Hero hero, Enemy enemy, char[,] map)
        {
            this.hero = hero;
            this.enemy = enemy;
            this.map = map;
        }
    }
}
