namespace DungeonsAndLizards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            // TODO : remove magic numbers

            var h = new Hero("Bron", "Dragonslayer", 100, 100, 2);
            var w = new Weapon("The Axe of Destiny", 20);
            h.Equip(w);

            string text = System.IO.File.ReadAllText(@"C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp-master\Week 5\OOPExercises\DungeonsAndLizards\map.txt");
            var map = new Dungeon(text);
            map.PrintMap();
            map.Spawn(h);
            map.MoveHero(Direction.Up);
            Console.WriteLine("--------------------");
            map.PrintMap();
            // TODO : check what cell you move in and do stuff
        }
    }
}
