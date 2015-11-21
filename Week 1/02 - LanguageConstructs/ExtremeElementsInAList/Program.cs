﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeElementsInAList
{
    class Program
    {
        public static int Min(int[] items)
        {
            return items.Min();
        }
        public static int Max(int[] items)
        {
            return items.Max();
        }
        public static int NthMax(int n, int[] items)
        {
            items = items.OrderByDescending(c => c).ToArray();
            return items[n - 1];
        }
        public static int NthMin(int n, int[] items)
        {
            items = items.OrderByDescending(c => c).Reverse().ToArray();
            return items[n - 1];
        }
        static void Main(string[] args)
        {
            int[] input = new int[5] { 1, 2, 3, 4, -3 };
            Console.WriteLine("Min numbers is : {0}", Min(input));
            Console.WriteLine("Max numbers is : {0}", Max(input));
            Console.WriteLine("Enter the nth max and min number you  want to see : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nth min numbers is : {0}",NthMax(n, input));
            Console.WriteLine("Nth min numbers is : {0}",NthMin(n,input));
        }
    }
}