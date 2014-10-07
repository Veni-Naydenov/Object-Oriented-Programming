//7.Using delegates write a class Timer that has can execute certain method at each t seconds.
using System;

namespace _07.Timer
{
    class Timer
    {
        static void PrintHi()
        {
            Console.WriteLine("Hi Nija!");
        }
        delegate void SingleDelegate();       

        static void Main()
        {
            SingleDelegate justHi = new SingleDelegate(PrintHi);
            while (!Console.KeyAvailable)
            {
                System.Threading.Thread.Sleep(1000); 
                justHi();
            }
        }
    }
}
