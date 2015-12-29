namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            // TODO : check addition of new characters, weapons and spells in the game
            // TODO : remove magic numbers
            // TODO : bugfixing
            // TODO : dungeon class violates SRP ?
            // check how to update map to default when moving ?
            var h = new Hero("Bron", "Dragonslayer", 100, 100, 2);
            var w = new Weapon("The Axe of Destiny", 20);
            h.Equip(w);

            string text = File.ReadAllText(@"C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp\Week 5\OOPExercises\DungeonsAndLizards\game settings\map.txt");
            var map = new Dungeon(text);
            //map.PrintMap();
            //map.Spawn(h);
            //Console.WriteLine("---------------------");
            //map.MoveHero(Direction.Left);
            //map.PrintMap();

            Console.WriteLine("Welcome to Dungeons and Lizards Game !");
            Console.WriteLine("To check game rules enter \"help\"");
            List<Hero> heroesList = new List<Hero>();
            List<Enemy> enemiesList = new List<Enemy>();
            List<Spell> spellsList = new List<Spell>();
            List<Weapon> weaponsList = new List<Weapon>();
            while (true)
            {
                string input = Console.ReadLine();
                string[] word = input.Split(' ');
                switch (word[0])
                {
                    case "help":
                        // print help menu
                        break;
                    case "create":
                        switch (word[1])
                        {
                            case "hero":
                                Hero hero = new Hero(word[2], word[3], int.Parse(word[4]), int.Parse(word[5]), int.Parse(word[6]));
                                heroesList[0] = (hero);
                                break;
                            case "enemy":
                                Enemy enemy = new Enemy(int.Parse(word[2]), int.Parse(word[3]), int.Parse(word[4]));
                                enemiesList.Add(enemy);
                                break;
                        }
                        break;
                    case "add":
                        switch (word[1])
                        {
                            case "weapon":
                                Weapon weapon = new Weapon(word[2], int.Parse(word[3]));
                                weaponsList[0] = weapon;
                                break;
                            case "spell":
                                Spell spell = new Spell(word[2], int.Parse(word[3]), int.Parse(word[4]), int.Parse(word[5]));
                                spellsList[0] = spell;
                                break;
                        }
                        break;
                    case "equip":
                        switch (word[1])
                        {
                            case "hero":
                                heroesList[0].Equip(weaponsList[0]);
                                break;
                            case "enemy":
                                enemiesList[0].Equip(weaponsList[0]);
                                break;
                        }
                        break;
                    case "learn":
                        switch (word[1])
                        {
                            case "hero":
                                heroesList[0].Learn(spellsList[0]);
                                break;
                            case "enemy":
                                enemiesList[0].Learn(spellsList[0]);
                                break;
                        }
                        break;
                    case "known":
                    case "knownAs":
                    case "knownas":
                        heroesList[0].KnownAs();
                        break;
                    case "isalive":
                    case "isAlive":
                        heroesList[0].IsAlive();
                        break;
                    case "can":
                        if (word[1] == "cast")
                        {
                            heroesList[0].CanCast(spellsList[0]);
                        }
                        break;
                    case "attack":
                        // attack method
                        break;
                    case "print":
                    case "printmap":
                        map.PrintMap();
                        break;
                    case "spawn":
                        // spawn hero
                        break;
                    case "move":
                        switch (word[1])
                        {
                            case "right":
                                map.MoveHero(Direction.Right);
                                break;
                            case "left":
                                map.MoveHero(Direction.Left);
                                break;
                            case "up":
                                map.MoveHero(Direction.Up);
                                break;
                            case "down":
                                map.MoveHero(Direction.Down);
                                break;
                        }
                        break;
                    case "exit":
                    case "quit":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
