namespace RandomNumbers
{
    using System;

    /// <summary>
    /// Write a method which outputs a matrix of random floating point numbers to a file. 
    /// The dimensions of the matrix are given as arguments. The numbers should be in the range 0-1000 
    /// and should be printed with exactly two digits after the decimal point. The numbers should be separated by at least one space
    ///  and should be right aligned to the size of their column (which you can consider to be fixed at 8 characters).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Generates a random matrix.
        /// </summary>
        /// <param name="rows">Matrix rows.</param>
        /// <param name="columns">Matrix columns.</param>
        /// <param name="fileName">String file name where the matrix should be saved.</param>
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

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            GenerateRandomMatrix(4, 4, "22");

            // TODO : Finish formatting
        }
    }
}
