namespace _06.DivisibleBySevenAndThree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    static class DivideNumbers
    {
        //Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
        //Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

        private static IEnumerable<int> LambdaDivideEpression(this IEnumerable<int> numbersArr, int divOne, int divTwo)
        {
            return numbersArr.Where(x => x % divOne == 0 && x % divTwo == 0);
        }

        private static IEnumerable<int> LinqDivideEpression(this IEnumerable<int> numbersArr, int divOne, int divTwo)
        {
            return from number in numbersArr
                   where (number % divOne == 0 && number % divTwo == 0)
                   select number;
        }

        static void Main(string[] args)
        {
            int[] numbersArr = new[] { 13, 12, 21, 25, 41, 42, 84, 3, 7 };

            Console.WriteLine("Numbers divisible by 7 and 3: ");
            Console.WriteLine("Lambda method: {0}", String.Join(", ", numbersArr.LambdaDivideEpression(7, 3)));
            Console.WriteLine("Linq method: {0}", String.Join(", ", numbersArr.LinqDivideEpression(7, 3)));

        }
    }
}
