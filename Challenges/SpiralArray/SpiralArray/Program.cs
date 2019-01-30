using System;

namespace SpiralArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[,] threeArray = new int[,]
            {
                {1,2,3},
                {8, 9,4},
                {7,6,5},
            };
            int[,] fourArray = new int[,]
            {
                {1,2,3,4},
                {12, 13,14,5},
                {11,16,15,6,},
                {10,9,8,7},
            };
            int[,] input = new int[,]
            {
                {1,2,3,4,5 },
                {16, 17,18,19,6 },
                {15,24,25,20,7 },
                {14,23,22,21,8 },
                {13,12,11,10,9 }
            };
            PrintSpiral(threeArray);
            Console.ReadKey();
        }

        static void PrintSpiral(int[,] input)
        {
            int nSize = input.GetLength(0); 
            for (int i = 0; i < Math.Ceiling(nSize/(double)2); i++)
            {
                for (int j = i; j < input.GetLength(1)-i; j++)
                {
                    Console.Write($"{input[i,j]}, ");
                }
                Console.WriteLine();

                for (int j = i; j < nSize - 1 - i; j++)
                {
                    Console.Write($"{input[j+1,nSize-i-1]}, ");
                }
                Console.WriteLine();

                for (int j = i; j < nSize - 1 - i; j++)
                {
                    Console.Write($"{input[nSize - i - 1, nSize - 2 - j]}, ");
                }
                Console.WriteLine();

                for (int j = i; j < nSize - 2 - i; j++)
                {
                    Console.Write($"{input[nSize-j-2, i]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
