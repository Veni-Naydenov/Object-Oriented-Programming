//2.Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
//   sum, product, min, max, average.
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ExtendIenumerable
{
    static class ExtendIenumerable
    {
        static public T Sum<T>(this IEnumerable<T> collection) where T : IComparable<T>, IComparable
        {
            dynamic sum = 0;

            foreach (var item in collection)
            {
                sum += item;
            }
            return sum;
        }

        static public T Product<T>(this IEnumerable<T> collection) where T : IComparable<T>, IComparable
        {
            dynamic product = 1;

            foreach (var item in collection)
            {
                product *= item;
            }
            return product;
        }

        static public T Min<T>(this IEnumerable<T> collection) where T : IComparable<T>, IComparable
        {
            int count = 0;
            dynamic min = double.MaxValue;

            foreach (var item in collection)
            {
                count++;
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            if (count == 0)
            {
                return default(T);
            }
            else
            {
                return min;
            }
        }

        static public T Max<T>(this IEnumerable<T> collection) where T : IComparable<T>, IComparable
        {
            int count = 0;
            dynamic max = double.MinValue;

            foreach (var item in collection)
            {
                count++;
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            if (count == 0)
            {
                return default(T);
            }
            else
            {
                return max;
            }
        }

        static public T Average<T>(this IEnumerable<T> collection) where T : IComparable<T>, IComparable
        {
            int count = 0;
            dynamic sum = 0;

            foreach (var item in collection)
            {
                count++;
                sum += item;
            }

            if (count == 0)
            {
                return default(T);
            }
            else
            {
                return sum / count;
            }
        }

        static void Main()
        {
            List<double> list = new List<double>();
            for (int i = 0; i < 15; i++)
            {
                list.Add(i+1 +(1d/(i+1)));
                Console.WriteLine("list value:[{0}] = {1}", i, list[i]);
            }

            Console.Write("\n-> Sum: {0} <---> ", list.Sum<double>());
            Console.WriteLine("Product: {0}\n", list.Product<double>());
            Console.Write("-> Min: {0} <---> ", list.Min<double>());
            Console.WriteLine("Max: {0}", list.Max<double>());
            Console.WriteLine("\n->  Average: {0}\n", list.Average<double>());
        }
    }
}
