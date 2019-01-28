using System;
using System.Collections.Generic;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string nemo = RemoveDuplicates("aaaaahuuuum");
            Console.WriteLine(nemo);

            Console.ReadKey();


        }

        static string RemoveDuplicates(string input)
        {
            char[] stringToChar = input.ToCharArray();
            List<char> noDuplicates = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                bool duplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (stringToChar[i] == stringToChar[j] && i>0)
                    {
                        duplicate = true;
                    }
                }
                if (duplicate == false)
                {
                    noDuplicates.Add(stringToChar[i]);
                }
            }

            string output = string.Join("", noDuplicates);
            return output;
        }
    }
}
