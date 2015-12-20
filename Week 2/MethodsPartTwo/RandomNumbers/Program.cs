namespace RandomNumbers
{
    using System;

    public class Program
    {
        public static void GenerateRandomMatrix(int rows, int columns, string fileName)
        {
            Random rand = new Random();
            double[,] matrix = new double[rows, columns];
            for (int r = 0; r < rows; r++)
            {
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

        public static void Main()
        {
            GenerateRandomMatrix(4, 4, "22");

            // TODO : Finish formatting
        }
    }
}
