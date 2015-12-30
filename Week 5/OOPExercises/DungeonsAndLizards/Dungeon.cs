namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public class Dungeon
    {
        private const string ERRORWHILEMOVING = "ERROR: moving in this direction is not possible";
        private const int WEAPON_DAMAGE = 69;
        private const char WALKABLE_PATH = '.';
        private readonly int[] defaultSpellStats = new int[] { 100, 50, 2 };
        private readonly int[] enemyStats = new int[] { 100, 100, 20 };
        private readonly char[,] matrix = new char[5, 10];
        private readonly Dictionary<KeyValuePair<int, int>, Enemy> enemiesList = new Dictionary<KeyValuePair<int, int>, Enemy>();
        private KeyValuePair<int, int> currPosition;
        private Hero hero;

        public Dungeon(string map)
        {
            string[] lines = map.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            int row = 0;
            foreach (string line in lines)
            {
                int column = 0;
                foreach (char character in line)
                {
                    if (character == 'E')
                    {
                        this.enemiesList.Add(new KeyValuePair<int, int>(row, column), new Enemy(this.enemyStats[0], this.enemyStats[1], this.enemyStats[2]));
                    }

                    this.matrix[row, column] = character;
                    column++;
                }

                row++;
            }
        }
        
        public void PrintCurrentCell()
        {
            switch (this.matrix[this.currPosition.Key, this.currPosition.Value])
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
                    this.HeroAttack(this.BiggerDamage());
                    break;
            }
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

        public bool Spawn(Hero heroToSpawn)
        {
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    if (this.matrix[row, col] == 'S')
                    {
                        this.matrix[row, col] = 'H';
                        this.currPosition = new KeyValuePair<int, int>(row, col);
                        this.hero = heroToSpawn;
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
                    if (this.currPosition.Key + 1 <= this.matrix.GetLength(0) && this.matrix[this.currPosition.Key + 1, this.currPosition.Value] != '#')
                    {
                        this.matrix[this.currPosition.Key, this.currPosition.Value] = WALKABLE_PATH;
                        this.currPosition = new KeyValuePair<int, int>(this.currPosition.Key + 1, this.currPosition.Value);
                        this.PrintCurrentCell();
                        this.matrix[this.currPosition.Key, this.currPosition.Value] = 'H';
                        return true;
                    }

                    Console.WriteLine(ERRORWHILEMOVING);
                    return false;
                case Direction.Up:
                    if (this.currPosition.Key - 1 >= 0 && this.matrix[this.currPosition.Key - 1, this.currPosition.Value] != '#')
                    {
                        this.matrix[this.currPosition.Key, this.currPosition.Value] = WALKABLE_PATH;
                        this.currPosition = new KeyValuePair<int, int>(this.currPosition.Key - 1, this.currPosition.Value);
                        this.PrintCurrentCell();
                        this.matrix[this.currPosition.Key, this.currPosition.Value] = 'H';
                        return true;
                    }

                    Console.WriteLine(ERRORWHILEMOVING);
                    return false;
                case Direction.Right:
                    if (this.currPosition.Value + 1 <= this.matrix.GetLength(1) && this.matrix[this.currPosition.Key, this.currPosition.Value + 1] != '#')
                    {
                        this.matrix[this.currPosition.Key, this.currPosition.Value] = WALKABLE_PATH;
                        this.currPosition = new KeyValuePair<int, int>(this.currPosition.Key, this.currPosition.Value + 1);
                        this.PrintCurrentCell();
                        this.matrix[this.currPosition.Key, this.currPosition.Value] = 'H';
                        return true;
                    }

                    Console.WriteLine(ERRORWHILEMOVING);
                    return false;
                case Direction.Left:
                    if (this.currPosition.Value - 1 >= 0 && this.matrix[this.currPosition.Key, this.currPosition.Value - 1] != '#')
                    {
                        this.matrix[this.currPosition.Key, this.currPosition.Value] = WALKABLE_PATH;
                        this.currPosition = new KeyValuePair<int, int>(this.currPosition.Key, this.currPosition.Value - 1);
                        this.PrintCurrentCell();
                        this.matrix[this.currPosition.Key, this.currPosition.Value] = 'H';
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
                    this.hero.TakeMana(this.hero.Mana.Value / 10);
                    if (this.hero.Mana.Value >= this.hero.MaxMana.Value)
                    {
                        Console.WriteLine("Mana potion. Hero mana is max");
                    }
                    else
                    {
                        Console.WriteLine("Mana potion. Hero mana is now {0}", this.hero.Mana.Value);
                    }

                    break;
                case 1:
                    this.hero.TakeHealing(this.hero.Health.Value / 10);
                    if (this.hero.Health.Value >= this.hero.MaxHealth.Value)
                    {
                        Console.WriteLine("Health potion. Hero health is max");
                    }
                    else
                    {
                        Console.WriteLine("Health potion. Hero health is now {0}", this.hero.Health.Value);
                    }

                    break;
                case 2:
                    this.hero.Weapon = new Weapon("Treasure Sword", WEAPON_DAMAGE);
                    Console.WriteLine("Treasure Sword with {0} damage", WEAPON_DAMAGE);
                    break;
                case 3:
                    this.hero.Spell = new Spell(
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

        public bool HeroAttack(string by)
        {
            if (by == "weapon" && this.matrix[this.currPosition.Key, this.currPosition.Value] == 'E')
            {
                foreach (var enemy in this.enemiesList)
                {
                    if (enemy.Key.Key == this.currPosition.Key && enemy.Key.Value == this.currPosition.Value)
                    {
                        new Fight(this.hero, enemy.Value, this.matrix);
                        return true;
                    }
                }
            }
            else if (by == "spell")
            {
                if (this.hero.HasSpell && this.InRange(this.matrix, this.currPosition, this.hero.Spell.CastRange))
                {
                    foreach (var enemy in this.enemiesList)
                    {
                        if (enemy.Key.Key == this.currPosition.Key && enemy.Key.Value == this.currPosition.Value)
                        {
                            new Fight(this.hero, enemy.Value, this.matrix);
                            return true;
                        }
                    }
                }

                Console.WriteLine("ERROR: Nothing in casting range {0}",this.hero.Spell.CastRange);
            }

            return false;
        }

        private int DiceRoll(int maxValue)
        {
            Random rnd = new Random();

            // TODO : check random number legitimacy
            int result = rnd.Next(0, maxValue);
            return result;
        }

        // TODO : check if InRange functons works legit
        private bool InRange(char[,] map, KeyValuePair<int, int> currLocation, int range)
        {
            for (int i = 1; i <= range; i++)
            {
                try
                {
                    if (map[currLocation.Key - i, currLocation.Value] == 'E')
                    {
                        return true;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                }
            }

            for (int i = 1; i <= range; i++)
            {
                try
                {
                    if (map[currLocation.Key + i, currLocation.Value] == 'E')
                    {
                        return true;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                }
            }

            for (int i = 1; i <= range; i++)
            {
                try
                {
                    if (map[currLocation.Key, currLocation.Value - i] == 'E')
                    {
                        return true;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                }
            }

            for (int i = 1; i <= range; i++)
            {
                try
                {
                    if (map[currLocation.Key, currLocation.Value + i] == 'E')
                    {
                        return true;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                }
            }

            return false;
        }

        private string BiggerDamage()
        {
            return this.hero.Weapon.Damage > this.hero.Spell.Damage ? "weapon" : "spell";
        }
    }
}
