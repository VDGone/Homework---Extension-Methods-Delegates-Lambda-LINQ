namespace _01.StringBuilderSubstring
{
    using System;
    using System.Text;

    public static class ExtencionStringBuilder
    {
        public static StringBuilder Substring(this StringBuilder sb, int startIndex, int length)
        {
            
            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("Start index is smaller than 0!");
            }

            if (startIndex >= sb.Length)
            {
                throw new ArgumentOutOfRangeException("Start index is bigger than string length!");
            }

            if (startIndex + length >= sb.Length)
            {
                throw new ArgumentOutOfRangeException("The length of the substring is too big.");
            }

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                result.Append(sb[startIndex + i]);
            }

            return result;
        }
    }
}
