namespace _01.StringBuilderSubstring
{
    using System;
    using System.Text;

    public class Substring
    {
        //Implement an extension method Substring(int index, int length) for the class StringBuilder that
        //returns new StringBuilder and has the same functionality as Substring in the class String.

        static void Main()
        {
            StringBuilder sb = new StringBuilder("Never trust a computer you can’t throw out a window.");
            Console.WriteLine(sb);
            sb = sb.Substring(6, 5);
            Console.WriteLine(sb);
        }
    }
}
