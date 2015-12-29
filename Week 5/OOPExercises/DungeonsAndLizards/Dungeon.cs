namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
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
        private const string ERRORWHILEMOVING = "ERROR: moving in this direction is not possible";
        private const int WEAPON_DAMAGE = 69;
        private const char WALKABLE_PATH = '.'; 
        private readonly int[] defaultSpellStats = new int[3] { 100, 50, 2 };
        private StringBuilder map;
        private char[,] matrix = new char[5, 10];
        private readonly char[,] matrixCopy;
        private KeyValuePair<int, int> currPosition;
        protected List<object> TreasureList = new List<object>();
        protected Hero Hero;

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
                    this.matrix[row, column] = character;
                    column++;
                }

                row++;
            }

            this.matrixCopy = this.matrix;
        }

        public void PrintCurrentCell()
        {
            switch (this.matrix[currPosition.Key, currPosition.Value])
            {
                case 'T':
                    Console.Write("You found a treasure - ");
                    this.PickTreasure();
                    break;
                case 'G':
                    Console.WriteLine("You reached the dungeon gateway! This is the exit from this dungeon");
                    break;
                case '.':
                    break;
                case 'E':
                    Console.WriteLine("You found an enemy.A fight is imminent !");
                    break;
            }
        }

        private int DiceRoll(int maxValue)
        {
            Random rnd = new Random();

            // TODO : check random number legitimacy
            int result = rnd.Next(0, maxValue);
            return result;

        }

        public void PrintMap()
        {
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    Console.Write(this.matrix[row, col]);
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
                        this.Hero = hero;
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
                    if (currPosition.Key + 1 <= matrix.GetLength(0) && this.matrix[currPosition.Key + 1, currPosition.Value] != '#')
                    {
                        this.matrix[currPosition.Key, currPosition.Value] = WALKABLE_PATH;
                        currPosition = new KeyValuePair<int, int>(currPosition.Key + 1, currPosition.Value);
                        PrintCurrentCell();
                        this.matrix[currPosition.Key, currPosition.Value] = 'H';
                        return true;
                    }

                    Console.WriteLine(ERRORWHILEMOVING);
                    return false;
                case Direction.Up:
                    if (currPosition.Key - 1 >= matrix.GetLength(0) && this.matrix[currPosition.Key - 1, currPosition.Value] != '#')
                    {
                        this.matrix[currPosition.Key, currPosition.Value] = WALKABLE_PATH;
                        currPosition = new KeyValuePair<int, int>(currPosition.Key - 1, currPosition.Value);
                        PrintCurrentCell();
                        this.matrix[currPosition.Key, currPosition.Value] = 'H';
                        return true;
                    }

                    Console.WriteLine(ERRORWHILEMOVING);
                    return false;
                case Direction.Right:
                    if (currPosition.Value + 1 <= matrix.GetLength(1) && this.matrix[currPosition.Key, currPosition.Value + 1] != '#')
                    {
                        this.matrix[currPosition.Key, currPosition.Value] = WALKABLE_PATH;
                        currPosition = new KeyValuePair<int, int>(currPosition.Key, currPosition.Value + 1);
                        PrintCurrentCell();
                        this.matrix[currPosition.Key, currPosition.Value] = 'H';
                        return true;
                    }

                    Console.WriteLine(ERRORWHILEMOVING);
                    return false;
                case Direction.Left:
                    if (currPosition.Value - 1 >= matrix.GetLength(1) &&
                        this.matrix[currPosition.Key, currPosition.Value - 1] != '#')
                    {
                        this.matrix[currPosition.Key, currPosition.Value] = WALKABLE_PATH;
                        currPosition = new KeyValuePair<int, int>(currPosition.Key, currPosition.Value - 1);
                        PrintCurrentCell();
                        this.matrix[currPosition.Key, currPosition.Value] = 'H';
                        return true;
                    }

                    Console.WriteLine(ERRORWHILEMOVING);
                    return false;
                default:
                    return false;
            }
        }

        public void PickTreasure()
        {
            string treasure = File.ReadAllText(@"C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp\Week 5\OOPExercises\DungeonsAndLizards\game settings\treasures.txt");
            int linesCount = File.ReadLines(@"C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp\Week 5\OOPExercises\DungeonsAndLizards\game settings\treasures.txt").Count();
            switch (this.DiceRoll(maxValue: linesCount))
            {
                case 0:
                    this.Hero.TakeMana(this.Hero.Mana.Value / 10);
                    if(this.Hero.Mana.Value >= this.Hero.MaxMana.Value)
                    {
                    Console.WriteLine("Mana potion. Hero mana is max");
                    }
                    else
                    {
                    Console.WriteLine("Mana potion. Hero mana is now {0}",this.Hero.Mana.Value);
                    }

                    break;
                case 1:
                    this.Hero.TakeHealing(Hero.Health.Value / 10);
                    if (this.Hero.Health.Value >= this.Hero.MaxHealth.Value)
                    {
                        Console.WriteLine("Health potion. Hero health is max");
                    }
                    else
                    {
                        Console.WriteLine("Health potion. Hero health is now {0}", this.Hero.Health.Value);
                    }

                    break;
                case 2:
                    this.Hero.Weapon = new Weapon("Treasure Sword", WEAPON_DAMAGE);
                    Console.WriteLine("Treasure Sword with {0} damage", WEAPON_DAMAGE);
                    break;
                case 3:
                    this.Hero.Spell = new Spell(
                        "Treasure Spell",
                        this.defaultSpellStats[0],
                        this.defaultSpellStats[1],
                        this.defaultSpellStats[2]);
                    Console.WriteLine("Treasure Spell with {0} damage", this.defaultSpellStats[0]);
                    break;
                default:
                    Console.WriteLine("Random numbers function broke :-(");
                    break;
            }
        }
    }
}
