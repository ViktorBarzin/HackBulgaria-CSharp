using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        public static void GenerateRandomMatrix(int rows, int columns, string fileName)
        {
            Random rand = new Random();
            double[,] matrix = new double[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                bool offset = false;
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = rand.NextDouble() * 1000;
                    if (matrix[r, c] < 100)
                    {
                        Console.Write(" {0:f2}".PadRight(8), matrix[r, c]);
                    }
                    else if (matrix[r, c] < 10)
                    {
                        Console.Write(" {0:f2}".PadRight(8), matrix[r, c]);
                    }
                    else
                    {
                        Console.Write("{0:f2}".PadRight(8), matrix[r, c]);
                    }
                }
                Console.WriteLine();
            }


        }
        static void Main(string[] args)
        {
            GenerateRandomMatrix(4, 4, "22");
            //TODO : Finish formatting
        }
    }
}
