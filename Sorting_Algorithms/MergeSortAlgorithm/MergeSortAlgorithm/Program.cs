using System;

namespace MergeSortAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] input = new int[11] { 6, 4, 2, 15, 7, 18, 12, 16, 23, 14, 9 };
            int[] input2 = new int[11] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{input2[i]}, ");
            }
            Console.WriteLine();
            int[] result = MergeSort(input2);
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{result[i]} ");
            }
            Console.ReadKey();
        }

        public static int[] MergeSort(int[] input)
        {
            if (input.Length <= 1)
            {
                return input;
            }

            int dividePoint = input.Length / 2;
            int[] leftArray = new int[dividePoint];
            int[] rightArray = new int[input.Length - dividePoint];
            int[] result = new int[input.Length];

            for (int i = 0; i < dividePoint; i++)
            {
                leftArray[i] = input[i];
            }

            for (int i = dividePoint; i < input.Length; i++)
            {
                rightArray[i-dividePoint] = input[i];
            }

            leftArray = MergeSort(leftArray);
            rightArray = MergeSort(rightArray);
            result = Merge(leftArray, rightArray);

            return result;
        }

        public static int[] Merge(int[] leftArray, int[] rightArray)
        {
            int[] result = new int[rightArray.Length + leftArray.Length];

            int left = 0, right = 0, indices = 0;

            while (left < leftArray.Length || right < rightArray.Length)
            {
                if (left < leftArray.Length && right < rightArray.Length)
                {
                    if (leftArray[left] <= rightArray[right])
                    {
                        result[indices] = leftArray[left];
                        left++;
                        indices++;
                    }
                    else
                    {
                        result[indices] = rightArray[right];
                        right++;
                        indices++;
                    }
                }
                else if (left < leftArray.Length)
                {
                    result[indices] = leftArray[left];
                    left++;
                    indices++;
                }
                else if (right < rightArray.Length)
                {
                    result[indices] = rightArray[right];
                    right++;
                    indices++;
                }
            }
            return result;
        }
    }
}
