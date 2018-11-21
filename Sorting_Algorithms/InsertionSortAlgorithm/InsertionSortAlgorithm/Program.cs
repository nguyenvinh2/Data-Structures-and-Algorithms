using System;

namespace InsertionSortAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] test = new int[10] { 6, 3, 4, 2, 7, 5, 3, 9, 7, 3 };


            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i]);
            }

            int[] outd = InsertionSort(test);

            Console.WriteLine();

            for (int i = 0; i < outd.Length; i++)
            {
                Console.Write(outd[i]);
            }

            Console.ReadKey();
        }
        /// <summary>
        /// iterates through loop for array
        /// use nested while loop
        /// maintains temp value in current
        /// compares current value to the previous value
        /// makes switch if current value is less than previous
        /// value. keeps on repeating throughout loop
        /// </summary>
        /// <param name="input">unsorted array</param>
        /// <returns>sorted array</returns>
        public static int[] InsertionSort(int[] input)
        {
            if (input == null)
            {
                return null;
            }
            int current, j;
            for (int i = 1; i < input.Length; i++)
            {
                current = input[i];
                j = i - 1;
                while (j >= 0 && input[j] > current)
                {
                    input[j + 1] = input[j];
                    j = j - 1;
                }
                input[j + 1] = current;
            }
            return input;
        }
    }
}
