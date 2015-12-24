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
            var h = new Hero("Bron", "Dragonslayer", 100, 100, 2);
            var w = new Weapon("The Axe of Destiny", 20);
            h.Equip(w);
            // TODO : continue from map

            string text = System.IO.File.ReadAllText(@"C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp-master\Week 5\OOPExercises\DungeonsAndLizards\map.txt");
            var map = new Dungeon(text);
            map.MoveHero(direction: Direction.Down);
        }
    }
}
