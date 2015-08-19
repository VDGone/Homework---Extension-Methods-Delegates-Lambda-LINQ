namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static decimal Sum<T>(this IEnumerable<T> collection) 
        {
            decimal result = 0;

            foreach (var element in collection)
            {
                result += Convert.ToDecimal(element);
            }

            return result;
        }

        public static decimal Product<T>(this IEnumerable<T> collection)
        {
            decimal result = 1;

            foreach (var element in collection)
            {
                result *= Convert.ToDecimal(element);
            }

            return result;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T min = collection.ElementAt(0);

            foreach (var element in collection)
            {
                if (element.CompareTo(min) < 0)
                {
                    min = element;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T max = collection.ElementAt(0);

            foreach (var element in collection)
            {
                if (element.CompareTo(max) > 0)
                {
                    max = element;
                }
            }

            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> collection)
        {
            decimal result = 0;
            result = collection.Sum() / collection.Count();
            return result;
        }
    }
}
