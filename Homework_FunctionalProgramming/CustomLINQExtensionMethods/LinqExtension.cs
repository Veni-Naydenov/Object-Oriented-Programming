using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLINQExtensionMethods
{
    public static class LinqExtension
    {

        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var result = collection.Where(i => !predicate(i));
            return result;
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            var repeatedColection = new List<T>();

            for (int i = 0; i < count; i++)
            {
                foreach (var item in collection)
                {
                    repeatedColection.Add(item);
                }
            }

            return repeatedColection;
        }

        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection,
            IEnumerable<string> suffixes)
        {
            var result = new List<String>();

            foreach (var suff in suffixes)
            {
                foreach (var str in collection)
                {
                    if (suff.Length <= str.Length)
                    {
                        string lastSubStr = str.Substring((str.Length - suff.Length));
                        if (lastSubStr == suff)
                        {
                            result.Add(str);
                        }
                    }
                }
            }

            return result;
        }
    }
}
