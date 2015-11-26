/*
You are given a NxM matrix of integer numbers.

We can drop a bomb at any place in the matrix, which has the following effect:

All of the 3 to 8 neighbours (depending on where you hit!) 
of the target are reduced by the value of the target.
Numbers can be reduced only to 0 - they cannot go to negative.
For example, if we have the following matrix:

10 10 10
10  9  10
10 10 10
and we drop bomb at 9, this will result in the following matrix:

1 1 1
1 9 1
1 1 1
Implement a function called int MatrixBombing(int[,] m).

The function should return the maximum damage we can inflict by bombing a single cell.
The damage in each cell is calculated as the difference between the old value and value after bombing.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBombing
{
    class Program
    {


        static int MatrixBombing(int[,] m)
        {
            int rows = m.GetLength(0);
            int cols = m.GetLength(1);

            int maxDamage = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int curDamage = 0;

                    for (int k = i - 1; k <= i + 1; k++)
                    {
                        for (int l = j - 1; l <= j + 1; l++)
                        {
                            if (k != i || l != j)
                            {
                                try
                                {
                                    curDamage += m[i, j] < m[k, l] ? m[i, j] : m[k, l];
                                }
                                catch (IndexOutOfRangeException) { }
                            }
                        }
                    }
                    if (maxDamage < curDamage) maxDamage = curDamage;
                }
            }

            return maxDamage;
        }

        static void Main(string[] args)
        {
            int[,] m = new int[,] {{9, 9, 9, 9},
                                   {9, 1, 9, 9},
                                   {9, 9, 9, 9}};

            Console.WriteLine(MatrixBombing(m));
            Console.ReadKey();
        }
    }
}

