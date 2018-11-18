using System;
using Hashtables.Classes;

namespace UniqueCharacterChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string one = "The quick brown fox jumps over the lazy dog";
            string two = "I love cats";
            string three = "Donald the duck";

            Console.WriteLine(one);
            Console.WriteLine(UniqueCharacter(one));
            Console.WriteLine();
            Console.WriteLine(two);
            Console.WriteLine(UniqueCharacter(two));
            Console.WriteLine();
            Console.WriteLine(three);
            Console.WriteLine(UniqueCharacter(three));
            Console.ReadKey();
        }
        /// <summary>
        /// takes in string, brings to lowercase, iterates
        /// through every character checks if it already exists
        /// in hashmap, if already exists returns false
        /// if not, adds to hashmap.
        /// if it doesn't return false after every iteration, then returns true.
        /// </summary>
        /// <param name="input">string</param>
        /// <returns>true/false</returns>
        public static bool UniqueCharacter(string input)
        {
            if (input == null)
            {
                return true;
            }
            Hashtable Storage = new Hashtable();
            string lowercase = input.ToLowerInvariant();
            for (int i = 0; i < lowercase.Length; i++)
            {
                if (lowercase[i] == 32)
                {
                }
                else
                {
                    if (Storage.Contains(lowercase[i].ToString()) == true)
                    {
                        return false;
                    }
                    else
                    {
                        Storage.Add(lowercase[i].ToString(),"Dummy");
                    }
                }
            }
            return true;
        }
    }
}
