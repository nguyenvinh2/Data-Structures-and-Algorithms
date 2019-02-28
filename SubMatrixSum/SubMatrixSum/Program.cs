using System;

namespace SubMatrixSum
{
    class Program
    {
        /// <summary>
        /// I have decided to do pascals triangle instead.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] input = new int[,]
                { {1,2,3,4,5 },
                {6,7,8,9,10 },
                {11,12,13,14,15 },
                {16,17,18,19,20 },
                {20,21,22,23, 24} };

            int[][] pascal = PascalTriangle(5);

            for (int i = 0; i < pascal.GetLength(0); i++)
            {
                for (int j = 0; j < pascal[i].Length; j++)
                {
                    Console.Write($"{pascal[i][j]}, ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static int[][] PascalTriangle(int input)
        {
            int[][] pascalArray = new int[input][];
            for (int i = 0; i < input; i++)
            {
                int[] pascalRow = new int[i + 1];
                for (int j = 0; j < i+1; j++)
                {
                    if (j == 0 || j == i)
                    {
                        pascalRow[j] = 1;
                    }
                    else
                    {
                        pascalRow[j] = pascalArray[i-1][j-1] + pascalArray[i - 1][j];
                    }
                }
                pascalArray[i] = pascalRow;
            }
            return pascalArray;
        }
    }
}
