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
        private char[,] matrix = new char[5, 10];
        private KeyValuePair<int, int> currPosition;

        public Dungeon(string map)
        {
            this.map = new StringBuilder(map);

            string[] lines = map.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            int row = 0;
            foreach (string line in lines)
            {
                int column = 0;
                foreach (char character in line)
                {
                    matrix[row, column] = character;
                    column++;
                }

                row++;
            }
        }

        public void PrintMap()
        {
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    Console.Write(this.matrix[row,col]);
                }
                Console.WriteLine();
            }
        }

        public bool Spawn(Hero hero)
        {
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        this.matrix[row, col] = 'H';
                        this.currPosition = new KeyValuePair<int, int>(row, col);
                    }
                }
            }
            return false;
        }

        public bool MoveHero(Direction direction)
        {
            switch (direction)
            {
                case Direction.Down:
                    if (currPosition.Key + 1 <= matrix.GetLength(0))
                    {
                        currPosition = new KeyValuePair<int, int>(currPosition.Key + 1, currPosition.Value);
                        this.matrix[currPosition.Key, currPosition.Value] = 'H';
                        return true;
                    }
                    return false;
                case Direction.Up:
                    if (currPosition.Key - 1 >= matrix.GetLength(0))
                    {
                        currPosition = new KeyValuePair<int, int>(currPosition.Key - 1, currPosition.Value);
                        this.matrix[currPosition.Key, currPosition.Value] = 'H';
                        return true;
                    }
                    return false;
                case Direction.Right:
                    if (currPosition.Value + 1 <= matrix.GetLength(1))
                    {
                        currPosition = new KeyValuePair<int, int>(currPosition.Key, currPosition.Value + 1);
                        this.matrix[currPosition.Key, currPosition.Value] = 'H';
                        return true;
                    }
                    return false;
                case Direction.Left:
                    if (currPosition.Value - 1 >= matrix.GetLength(1))
                    {
                        currPosition = new KeyValuePair<int, int>(currPosition.Key, currPosition.Value - 1);
                        this.matrix[currPosition.Key, currPosition.Value] = 'H';
                        return true;
                    }
                    return false;
                default:
                    return false;
            }
        }
    }
}
