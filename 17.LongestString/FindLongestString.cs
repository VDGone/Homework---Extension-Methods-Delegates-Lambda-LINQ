namespace _17.LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class FindLongestString
    {
        public static string Longest(IList<string> arr)
        {
            return arr.OrderByDescending(x => x.Length).First();
        }

        static string[] GenerateStrings()
        {
            Random rand = new Random();

            string[] arrayOfStrings = new string[rand.Next(1, 30)];

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                arrayOfStrings[i] = new string((char)rand.Next(60, 90), rand.Next(1, 50));
            }

            return arrayOfStrings;
        }

        static void Main(string[] args)
        {
            var strings = GenerateStrings();
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }
            Console.WriteLine();

            var longest = Longest(strings);
            Console.WriteLine("\n\rLongest string is: \r{0}",longest);
        }
    }
}
