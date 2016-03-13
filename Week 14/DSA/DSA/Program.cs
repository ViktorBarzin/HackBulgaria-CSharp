using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Panda panda1 = new Panda("Panda 1");
            Panda panda2 = new Panda("Panda 2");
            Panda panda3 = new Panda("Panda 3");
            Panda panda4 = new Panda("Panda 4");
            Panda panda5 = new Panda("Panda 5");
            Panda panda6 = new Panda("Panda 6");
            Panda panda7 = new Panda("Panda 7");
            Panda panda8 = new Panda("Panda 8");
            Panda panda9 = new Panda("Panda 9");
            Panda panda10 = new Panda("Panda 10");

            panda1.Friends.Add(panda4);
            panda4.Friends.Add(panda1);

            panda2.Friends.Add(panda5);
            panda5.Friends.Add(panda2);

            panda5.Friends.Add(panda6);
            panda6.Friends.Add(panda5);

            panda6.Friends.Add(panda3);
            panda3.Friends.Add(panda6);

            panda6.Friends.Add(panda9);
            panda9.Friends.Add(panda6);

            panda9.Friends.Add(panda8);
            panda8.Friends.Add(panda9);

            panda8.Friends.Add(panda10);
            panda10.Friends.Add(panda8);

            panda7.Friends.Add(panda10);
            panda10.Friends.Add(panda7);

            //Console.WriteLine(AreFriends(panda1,panda6));
            Populate(new int[15],-1 );
        }

        public static bool AreFriends(Panda p1, Panda p2)
        {
            Stack<Panda> q = new Stack<Panda>();
            HashSet<Panda> visited = new HashSet<Panda> { p1 };

            q.Push(p1);
            while (q.Count > 0)
            {
                Panda current = q.Pop();
                if (current.Name == p2.Name)
                {
                    return true;
                }
                foreach (var friend in current.Friends.Where(friend => !visited.Contains(friend)))
                {
                    q.Push(friend);
                    visited.Add(friend);
                }
            }

            return false;
        }

        public static void Populate(int[] arr, int index)
        {
            if (index +1== arr.Length)
            {
                Console.WriteLine(string.Join(",", arr));
                return;
            }
            index ++;

            arr[index] = 0;
            Populate(arr, index);
            
            arr[index] = 1;
            Populate(arr,index);
        }
    }
}
