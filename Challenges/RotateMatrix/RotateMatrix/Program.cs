using System;

namespace RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] input = new int[,]
            {
                { 1,2,3, 4 },
                { 5,6,7,8 },
                { 9,10,11,12 },
                {13,14,15,16 },
            };

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Console.Write(input[i, j]);
                }

                Console.WriteLine();
            }

            RotateMatrix(input);

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Console.Write(input[i, j]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();

        }




        static void RotateMatrix(int[,] matrix)
        {
            int nSize = matrix.GetLength(0);
            for (int i = 0; i < nSize / 2; i++)
            {
                for (int j = i; j < nSize - i - 1; j++)
                {
                    int temp = matrix[i, j];
                    //Right to top
                    matrix[i, j] = matrix[j, nSize - i - 1];
                    //Bottom to Right
                    matrix[j, nSize - i - 1] = matrix[nSize - i - 1, nSize - j - 1];
                    //left to Bottom
                    matrix[nSize - i - 1, nSize - j - 1] = matrix[nSize - j - 1, i];
                    //Top to Left
                    matrix[nSize - j - 1, i] = temp;
                }
            }
        }
    }

}
