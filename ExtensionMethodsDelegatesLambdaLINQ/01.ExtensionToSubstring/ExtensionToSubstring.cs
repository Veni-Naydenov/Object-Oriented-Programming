//1.Implement an extension method Substring(int index, int length) for the class StringBuilder that 
//returns new StringBuilder and has the same functionality as Substring in the class String.
using System;
using System.Text;

namespace _01.ExtensionToSubstring
{
    static class ExtensionToSubstring
    {
        static public StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            if (index + length > str.Length - 1)
            {
                throw new IndexOutOfRangeException("Trying to access invalid index in string.");
            }
            StringBuilder substring = new StringBuilder(length);

            for (int i = index; i < index + length; i++)
            {
                substring.Append(str[i]);
            }
            return substring;
        }
        static void Main()
        {
            string myString = "The .NET Framework's Base Class Library provides user interface,data access, database connectivity, cryptography, web application development, numeric algorithms, and network communications.";
            StringBuilder str = new StringBuilder(myString);
            Console.Write("Choose index from 0 to {0} and length <{0} \nindex: ", myString.Length - 1);
            int index = int.Parse(Console.ReadLine());
            Console.Write("length: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine(str.Substring(index, length)); 
        }
    }
}
