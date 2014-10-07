//6.Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
// Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
using System;
using System.Linq;

namespace _06.ExtractArrayElementByCondition
{
    class ExtractElementDivisibleBy21
    {
        static void Main()
        {
            int[] testArray = new int[300];

            for (int i = 0; i < 300; i++) 
            {
                testArray[i] = i + 1;
            }

            Console.WriteLine("Lambda expression result: ");

            var divisable = testArray.Where(x => (x % 21 == 0));

            foreach (var num in divisable)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("LinQ result: ");

            var linqDivisable =
                from int y in testArray
                where y % 21 == 0
                select y;

            foreach (var num in linqDivisable)
            {
                Console.WriteLine(num);
            }
        }
    }
}
