using System;

namespace BitArray
{
    class TestBitArray
    {
        static void Main()
        {
            BitArray myArray = new BitArray(33);
            myArray[32] = 1;

            Console.WriteLine("\tDecimal Number:\n{0}", myArray.ToString());
            Console.WriteLine("\tBits:\n{0}", myArray.GetBits());

            Console.WriteLine(new string('-', 75));

            BitArray myArray2 = new BitArray(100);
            myArray2[32] = 1;
            myArray2[2] = 1;
            myArray2[45] = 1;
            myArray2[50] = 1;

            Console.WriteLine("\tDecimal Number:\n{0}", myArray2.ToString());
            Console.WriteLine("\tBits:\n{0}", myArray2.GetBits());

            //BitArray array = new BitArray(100000);
            //array[9999] = 1;

            //Console.WriteLine("\tDecimal Number:\n{0}", array.ToString());
            ////Console.WriteLine("\tBits:\n{0}", array.GetBits());
        }
    }
}
