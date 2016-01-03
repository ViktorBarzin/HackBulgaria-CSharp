namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// Moving direction.
    /// </summary>
    public enum Direction
    {
        /// <summary>
        /// Reduces rows by 1.
        /// </summary>
        Up,

        /// <summary>
        /// Increases rows by 1.
        /// </summary>
        Down,

        /// <summary>
        /// Reduces cols by 1.
        /// </summary>
        Left,

        /// <summary>
        /// Increases cols by 1.
        /// </summary>
        Right
    }

    /// <summary>
    /// The main part of the application.
    /// </summary>
    public class Dungeon
    {
        /// <summary>
        /// Error while moving constant.
        /// </summary>
        private const string ERRORWHILEMOVING = "ERROR: moving in this direction is not possible";

        /// <summary>
        /// Weapon damage constant.
        /// </summary>
        private const int WEAPONDAMAGE = 69;

        /// <summary>
        /// Walkable path char symbol.
        /// </summary>
        private const char WALKABLEPATH = '.';

        /// <summary>
        /// Default Spell stats.
        /// </summary>
        private readonly int[] defaultSpellStats = new int[] { 100, 50, 2 };

        /// <summary>
        /// Default enemy stats.
        /// </summary>
        private readonly int[] enemyStats = new int[] { 100, 100, 20 };

        /// <summary>
        /// Matrix size.
        /// </summary>
        private readonly char[,] matrix = new char[5, 10];

        /// <summary>
        /// List of enemies on the map.
        /// </summary>
        private readonly List<Enemy> enemiesList = new List<Enemy>();

        /// <summary>
        /// Holds the current position of the Hero.
        /// </summary>
        private KeyValuePair<int, int> currPosition;

        /// <summary>
        /// Hero instance used for the game.
        /// </summary>
        private Hero hero;

        /// <summary>
        /// Enemy instance to fight.
        /// </summary>
        private Enemy enemyToFight;

        /// <summary>
        /// Initializes a new instance of the <see cref="Dungeon"/> class.
        /// </summary>
        /// <param name="map">String which holds the map of the dungeon.</param>
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
                        Enemy newEnemy = new Enemy(this.enemyStats[0], this.enemyStats[1], this.enemyStats[2]);
                        this.enemiesList.Add(newEnemy);
                        newEnemy.CurrentPosition = new KeyValuePair<int, int>(row, column);
                    }

                    this.matrix[row, column] = character;
                    column++;
                }

                row++;
            }
        }

        /// <summary>
        /// Checks the current cell and does action upon it.
        /// </summary>
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

        /// <summary>
        /// Prints the map.
        /// </summary>
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

        /// <summary>
        /// Spawns a Hero at the first spawn location.
        /// </summary>
        /// <param name="heroToSpawn">Hero to spawn.</param>
        /// <returns>True if successful spawn.</returns>
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
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Moves hero in the desired direction if valid.
        /// </summary>
        /// <param name="direction">Direction to move in.</param>
        /// <returns>True if move was successful.</returns>
        public bool MoveHero(Direction direction)
        {
            switch (direction)
            {
                case Direction.Down:
                    if (this.currPosition.Key + 1 <= this.matrix.GetLength(0) && this.matrix[this.currPosition.Key + 1, this.currPosition.Value] != '#')
                    {
                        this.matrix[this.currPosition.Key, this.currPosition.Value] = WALKABLEPATH;
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
                        this.matrix[this.currPosition.Key, this.currPosition.Value] = WALKABLEPATH;
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
                        this.matrix[this.currPosition.Key, this.currPosition.Value] = WALKABLEPATH;
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
                        this.matrix[this.currPosition.Key, this.currPosition.Value] = WALKABLEPATH;
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

        /// <summary>
        /// Picks a randomly-selected treasure from the treasure list.
        /// </summary>
        public void PickTreasure()
        {
            int treasuresCount = File.ReadLines(@"C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp\Week 5\OOPExercises\DungeonsAndLizards\game settings\treasures.txt").Count();
            switch (this.DiceRoll(maxValue: treasuresCount))
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
                    this.hero.Weapon = new Weapon("Treasure Sword", WEAPONDAMAGE);
                    Console.WriteLine("Treasure Sword with {0} damage", WEAPONDAMAGE);
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

        /// <summary>
        /// Hero attacks if in range of an enemy.
        /// </summary>
        /// <param name="by">Hero can attack either by weapon or by spell.</param>
        /// <returns>Returns true if in range to attack.</returns>
        public bool HeroAttack(string by)
        {
            if (by == "weapon" && this.matrix[this.currPosition.Key, this.currPosition.Value] == 'E')
            {
                foreach (var enemy in this.enemiesList)
                {
                    if (enemy.CurrentPosition.Key == this.currPosition.Key && enemy.CurrentPosition.Value == this.currPosition.Value)
                    {
                        new Fight(this.hero, enemy, this.matrix);
                        return true;
                    }
                }
            }
            else if (by == "spell")
            {
                if (this.hero.HasSpell && this.InRange())
                {
                    new Fight(this.hero, this.enemyToFight, this.matrix);
                    return true;
                }

                Console.WriteLine("Nothing in casting range {0}", this.hero.Spell.CastRange);
            }

            return false;
        }

        /// <summary>
        /// Random number generator.
        /// </summary>
        /// <param name="maxValue">Generates random numbers from 0 to maxValue.</param>
        /// <returns>A random generated number from 0 to input value including.</returns>
        private int DiceRoll(int maxValue)
        {
            Random rnd = new Random();
            
            int result = rnd.Next(0, maxValue);
            return result;
        }

        /// <summary>
        /// Checks if hero is in range with spell.
        /// </summary>
        /// <returns>True if Hero is in range to attack with spell.</returns>
        private bool InRange()
        {
            for (int i = 0; i <= this.hero.Spell.CastRange; i++)
            {
                if (this.currPosition.Key + i < this.matrix.GetLength(0))
                {
                    if (this.matrix[this.currPosition.Key + i, this.currPosition.Value] == 'E')
                    {
                        foreach (var enemy in this.enemiesList)
                        {
                            if (enemy.CurrentPosition.Key == this.currPosition.Key + i && enemy.CurrentPosition.Value == this.currPosition.Value)
                            {
                                this.enemyToFight = enemy;
                            }
                        }

                        return true;
                    }
                }

                if (this.currPosition.Key - i >= 0)
                {
                    if (this.matrix[this.currPosition.Key - i, this.currPosition.Value] == 'E')
                    {
                        foreach (var enemy in this.enemiesList)
                        {
                            if (enemy.CurrentPosition.Key == this.currPosition.Key - i && enemy.CurrentPosition.Value == this.currPosition.Value)
                            {
                                this.enemyToFight = enemy;
                            }
                        }

                        return true;
                    }
                }

                if (this.currPosition.Value + i < this.matrix.GetLength(1))
                {
                    if (this.matrix[this.currPosition.Key, this.currPosition.Value + i] == 'E')
                    {
                        foreach (var enemy in this.enemiesList)
                        {
                            if (enemy.CurrentPosition.Key == this.currPosition.Key && enemy.CurrentPosition.Value + i == this.currPosition.Value)
                            {
                                this.enemyToFight = enemy;
                            }
                        }

                        return true;
                    }
                }

                if (this.currPosition.Value - i >= 0)
                {
                    if (this.matrix[this.currPosition.Key, this.currPosition.Value - i] == 'E')
                    {
                        foreach (var enemy in this.enemiesList)
                        {
                            if (enemy.CurrentPosition.Key == this.currPosition.Key && enemy.CurrentPosition.Value - i == this.currPosition.Value)
                            {
                                this.enemyToFight = enemy;
                            }
                        }

                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Returns the weapon that has more damage.
        /// </summary>
        /// <returns>Either weapon or spell as strings.</returns>
        private string BiggerDamage()
        {
            if (this.hero.HasWeapon && this.hero.HasSpell)
            {
                return this.hero.Weapon.Damage > this.hero.Spell.Damage ? "weapon" : "spell";
            }

            if (this.hero.HasWeapon ^ this.hero.HasSpell)
            {
                if (this.hero.HasWeapon)
                {
                    return "weapon";
                }

                return "spell";
            }

            throw new ArgumentNullException();
        }
    }
}
