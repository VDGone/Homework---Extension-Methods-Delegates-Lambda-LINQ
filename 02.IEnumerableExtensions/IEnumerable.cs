namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public class IEnumerable
    {
        //Implement a set of extension methods for IEnumerable<T> that implement the following group 
        //functions: sum, product, min, max, average.

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(7);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Sum of numbers: {0}", numbers.Sum());
            Console.WriteLine("Product of numbers: {0}", numbers.Product());
            Console.WriteLine("Min number in list: {0}", numbers.Min());
            Console.WriteLine("Max number in list: {0}", numbers.Max());
            Console.WriteLine("Average number in list: {0}", numbers.Average());
            
        }
    }
}
