using System.Globalization;
using System.IO;

namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Dungeon
    {
        private StringBuilder map;
        private char[,] matrix;

        public Dungeon(string map)
        {
            this.map = new StringBuilder(map);

            string[] lines = map.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            
        }

        public void PrintMap()
        {
            Console.WriteLine(this.map);
        }

        public bool Spawn(Hero hero)
        {
            for (int i = 0; i < this.map.Length; i++)
            {
                if (this.map[i] == 'S')
                {
                    this.map.Replace(this.map[i], 'H');
                    return true;
                }
            }
            return false;
        }

        public bool MoveHero(Direction direction)
        {
            switch (direction)
            {
                case Direction.Down:

                    break;
            }
            return true;
        }
    }
}
