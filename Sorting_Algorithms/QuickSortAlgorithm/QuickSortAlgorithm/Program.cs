using System;

namespace QuickSortAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] myArray = { 90, 20, 30, 90, 40, 40, 70 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]}, ");
            }
            Console.WriteLine();
            QuickSort(myArray, 0, myArray.Length - 1);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]}, ");
            }

            Console.ReadKey();
        }
        /// <summary>
        /// sorts array via the quicksort method
        /// </summary>
        /// <param name="input">array to be sorted</param>
        /// <param name="left">left index of array</param>
        /// <param name="right">right index of arrya</param>
        public static void QuickSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(input, left, right);

                if (pivot > 1)
                {
                    QuickSort(input, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(input, pivot + 1, right);
                }
            }

        }
        /// <summary>
        /// finds where the pivot should be in a sorted array and moves it there
        /// </summary>
        /// <param name="input">array</param>
        /// <param name="left">left index</param>
        /// <param name="right">rright index</param>
        /// <returns></returns>
        private static int Partition(int[] input, int left, int right)
        {
            int pivot = input[left];
            while (true)
            {
                while (input[left] < pivot)
                {
                    left++;
                }
                while (input[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = input[left];
                    input[left] = input[right];
                    input[right] = temp;

                    if (input[left] == input[right])
                    {
                        left++;
                    }
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
