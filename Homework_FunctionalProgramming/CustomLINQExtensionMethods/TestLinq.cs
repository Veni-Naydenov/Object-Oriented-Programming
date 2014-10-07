using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLINQExtensionMethods
{
    class TestLinq
    {
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public static bool isUpper(char letter)
        {
            return letter.ToString().ToUpper() == letter.ToString();
        }

        static void Main()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Func<int, bool> func = IsEven;
            var newList = list.WhereNot(IsEven);

            Console.WriteLine("WhereNot Even:");

            foreach (var item in newList)
            {
                Console.Write(item + " ");
            }

            string str = "AsdDjKLPoiL";

            Console.WriteLine("\n\nText: {0}", str);
            Console.WriteLine("WhereNot Upper case letter:");

            var onlyLower = str.WhereNot(isUpper);

            foreach (var letter in onlyLower)
            {
                Console.Write("{0} ", letter);
            }
            Console.WriteLine("\n");

            //test Repeat
            var repeated = list.Repeat(3);
            foreach (var item in repeated)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            var repeateString = str.Repeat(3);
            foreach (var item in repeateString)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n\nTest WhereEndsWith:\n");

            //test WhereEndsWith
            var strList = new string[] { "Ala", "Bala", "GXS", "Php", "java", "Csharp" };
            string[] suffixes = new string[] { "la", "XS", "va" };
            var elements = strList.WhereEndsWith(suffixes);

            foreach (var item in elements)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("\n");
        }
    }
}
