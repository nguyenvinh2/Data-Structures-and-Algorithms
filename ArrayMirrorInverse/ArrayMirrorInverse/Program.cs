using System;

namespace ArrayMirrorInverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] input = new int[] { 1,2,3,0 };
            Console.WriteLine(MirrorInverse(input));
            Console.ReadKey();

        }
        /// <summary>
        /// takes an array of integers, checks to see if index value is 
        /// equal the value resulting from taking the value of the first index value
        /// and using that as the index
        /// </summary>
        /// <param name="input">int array</param>
        /// <returns>true or false</returns>
        static bool MirrorInverse(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i != input[input[i]])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
