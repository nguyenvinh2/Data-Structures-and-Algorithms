using System;
using Hashtables.Classes;
using System.Text.RegularExpressions;


namespace RepeatedWordChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string input = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";

            Console.WriteLine(input);

            string answer = RepeatedWord(input);

            Console.WriteLine();
            Console.WriteLine(answer);

            Console.ReadKey();
        }
        /// <summary>
        /// brings input to lowercase
        /// splits it into array
        /// checks if its already in a hashtable
        /// hashes it if it isn't
        /// </summary>
        /// <param name="input">list of words</param>
        /// <returns></returns>
        public static string RepeatedWord(string input)
        {
            if (input == null)
            {
                return null;
            }
            string[] words = input.ToLowerInvariant().Split(" ");
            string stripped;
            Hashtable Storage = new Hashtable();

            for (int i = 0; i < words.Length; i++)
            {
                stripped = Regex.Replace(words[i], @"[^\w\s]", "");
                if (Storage.Contains(stripped))
                {
                    return stripped;
                }
                else
                {
                    Storage.Add(stripped,"dummy value");
                }
            }
            return null;
        }
    }
}
