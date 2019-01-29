using System;

namespace MajorityElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] input = new int[] { 2, 6, 5, 6, 7, 6, 6, 12, 3,6 };
            Console.WriteLine(input.Length / 2);
            Console.WriteLine(FindElement(input));
            Console.ReadKey();
        }

        static int FindElement(int[] inputArray)
        {
            int element = 0;
            int count = 0;

            int[] input = MergeSort(inputArray);

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    element = input[i];
                    count++;
                }
                else if (input[i] == input[i - 1])
                {
                    count++;
                }
                else
                {
                    if (count >= input.Length / 2)
                    {
                        return element;
                    }
                    element = input[i];
                    count = 1;
                }

            }
            return 0;

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
                rightArray[i - dividePoint] = input[i];
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
