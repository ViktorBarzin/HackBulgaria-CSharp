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
        private readonly List<Enemy> enemiesList = new List<Enemy>();
        private KeyValuePair<int, int> currPosition;
        private Hero hero;
        private Enemy enemyToFight;

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

        private int DiceRoll(int maxValue)
        {
            Random rnd = new Random();

            // TODO : check random number legitimacy
            int result = rnd.Next(0, maxValue);
            return result;
        }

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

        private string BiggerDamage()
        {
            return this.hero.Weapon.Damage > this.hero.Spell.Damage ? "weapon" : "spell";
        }
    }
}
