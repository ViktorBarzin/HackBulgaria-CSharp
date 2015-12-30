namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            // TODO : add fights feature
                // TODO : combat method for fights
            // TODO : enemy adding order ?
            // TODO : check addition of new characters, weapons and spells in the game
            // TODO : add validation
            // TODO : refactor with build methods (take damage, take healing etc)
            // TODO : remove magic numbers
            // TODO : bugfixing
            // TODO : dungeon class violates SRP ?
            var defaultHero = new Hero("John", "Smith", 100, 100, 2);
            var defaultWeapon = new Weapon("Default weapon", 100);
            var defaultSpell = new Spell("Default spell", 120, 50, 2);
            List<Enemy> enemiesList = new List<Enemy>();
            bool isSpawned = false;
            
            defaultHero.Learn(defaultSpell);
            defaultHero.Equip(defaultWeapon);

            string text = File.ReadAllText(@"C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp\Week 5\OOPExercises\DungeonsAndLizards\game settings\map.txt");
            var dungeon = new Dungeon(text);

            Console.WriteLine("Welcome to Dungeons and Lizards Game !");
            Console.WriteLine("To check game rules enter \"help\"");

            // TODO : equip enemies/heroes with different spells and weapons?
            int enemiesCounter = text.Count(character => character == 'E');

            while (true)
            {
                Console.Write("Enter a command: ");
                string input = Console.ReadLine();
                string[] word = input.Split(' ');
                switch (word[0])
                {
                    case "help":
                        Console.WriteLine("List of commands : ");
                        Console.WriteLine("Replace \"<>\" with desired stats");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("create hero <hero name> <hero class> <hero heatlh> <hero mana> <hero mana regeneration>");
                        Console.WriteLine("create enemy <enemy health> <enemy mana> <enemy damage>");
                        Console.WriteLine("add weapon <weapon name> <weapon damage>");
                        Console.WriteLine("add spell <spell name> <spell damage> <spell manacost> <spell range>");
                        Console.WriteLine("equip hero");
                        Console.WriteLine("equip enemy");
                        Console.WriteLine("learn hero");
                        Console.WriteLine("learn enemy");
                        Console.WriteLine("known as");
                        Console.WriteLine("is alive");
                        Console.WriteLine("can cast");
                        Console.WriteLine("attack");
                        Console.WriteLine("print map");
                        Console.WriteLine("move <any of the 4 directions>");
                        Console.WriteLine("exit/quit");
                        Console.WriteLine("----------------------------------------");
                        break;
                    case "create":
                        switch (word[1])
                        {
                            case "hero":
                                Hero hero = new Hero(word[2], word[3], int.Parse(word[4]), int.Parse(word[5]), int.Parse(word[6]));
                                defaultHero = hero;
                                Console.WriteLine("SUCCESS: Hero created !");
                                break;
                            case "enemy":
                                if (enemiesCounter > enemiesList.Count)
                                {
                                    Enemy enemy = new Enemy(int.Parse(word[2]), int.Parse(word[3]), int.Parse(word[4]));
                                    enemiesList.Add(enemy);
                                    Console.WriteLine("SUCCESS: Enemy created !");
                                }
                                else
                                {
                                    Console.WriteLine("ERROR: You cannot add more enemies because there are too few on the map !");
                                }

                                break;
                            default:
                                Console.WriteLine("ERROR: Command \"create\" take \"hero\" or \"enemy\" as parameters !");
                                break;
                        }

                        break;
                    case "add":
                        switch (word[1])
                        {
                            case "weapon":
                                Weapon weapon = new Weapon(word[2], int.Parse(word[3]));
                                defaultWeapon = weapon;
                                Console.WriteLine("SUCCESS: Weapon added !");
                                break;
                            case "spell":
                                Spell spell = new Spell(word[2], int.Parse(word[3]), int.Parse(word[4]), int.Parse(word[5]));
                                defaultSpell = spell;
                                Console.WriteLine("SUCCESS: Spell added !");
                                break;
                            default:
                                Console.WriteLine("ERROR: Command \"add\" takes \"weapon\" or \"spell\" as parameters !");
                                break;
                        }

                        break;
                    case "equip":
                        switch (word[1])
                        {
                            case "hero":
                                defaultHero.Equip(defaultWeapon);
                                Console.WriteLine("SUCCESS: Hero equipped !");
                                break;
                            case "enemy":
                                enemiesList[0].Equip(defaultWeapon);
                                Console.WriteLine("SUCCESS: Enemy equipped !");
                                break;
                            default:
                                Console.WriteLine("ERROR: Command \"equip\" takes \"hero\" or \"enemy\" as parameters !");
                                break;
                        }

                        break;
                    case "learn":
                        switch (word[1])
                        {
                            case "hero":
                                defaultHero.Learn(defaultSpell);
                                Console.WriteLine("SUCCESS: {0} learned {1} spell", defaultHero.Name, defaultSpell.Name);
                                break;
                            case "enemy":
                                enemiesList[0].Learn(defaultSpell);
                                Console.WriteLine("SUCCESS: {0} learned {1} spell", enemiesList[0].Name, defaultSpell.Name);
                                break;
                            default:
                                Console.WriteLine("ERROR: Command \"learn\" takes \"hero\" or \"enemy\" as parameters !");
                                break;
                        }

                        break;
                    case "known":
                    case "knownAs":
                    case "knownas":
                        Console.WriteLine(defaultHero.KnownAs());
                        break;
                    case "isalive":
                    case "isAlive":
                        Console.WriteLine("Hero is alive : {0}", defaultHero.IsAlive());
                        break;
                    case "can":
                        if (word[1] == "cast")
                        {
                            Console.WriteLine("Hero can cast {0} : {1}", defaultSpell, defaultHero.CanCast(defaultSpell));
                        }

                        break;
                    case "attack":
                        switch (word[1])
                        {
                            case "weapon":
                            case "spell":
                                dungeon.HeroAttack(word[1]);
                                break;
                            default:
                                Console.WriteLine("ERROR: Command \"attack\" takes \"weapon\" or \"spell\" as parameters");
                                break;
                        }

                        break;

                    case "print":
                    case "printmap":
                        dungeon.PrintMap();
                        break;
                    case "spawn":
                        // if (defaultHero.Equals(defaultHero))
                        // {
                        //    Console.WriteLine("WARNING: You are using the default hero");
                        // }
                        if (!isSpawned)
                        {
                            dungeon.Spawn(defaultHero);
                            Console.WriteLine("SUCCES: {0} spawned !", defaultHero.Name);
                            isSpawned = true;
                        }
                        else
                        {
                            Console.WriteLine("ERROR: You have already spawned a hero !");
                        }

                        break;
                    case "move":
                            if (isSpawned)
                            {
                                switch (word[1])
                                {
                                    case "right":
                                        dungeon.MoveHero(Direction.Right);
                                        break;
                                    case "left":
                                        dungeon.MoveHero(Direction.Left);
                                        break;
                                    case "up":
                                        dungeon.MoveHero(Direction.Up);
                                        break;
                                    case "down":
                                        dungeon.MoveHero(Direction.Down);
                                        break;
                                    default:
                                        Console.WriteLine("ERROR: command \"move\" can be used only with \"up\", \"down\", \"left\" or \"right\"");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("ERROR: Hero not spawned !");
                            }

                        break;
                    case "exit":
                    case "quit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("ERROR: Unknown command \"{0}\"", input);
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
