namespace SquareRoot
{
    using System;

    class SqrtExeption
    {
        public static double Sqrt(double num)
        {
            if (num < 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }

            return Math.Sqrt(num);
        }

        static void Main()
        {
            Console.Write("Enter some int number: ");

            try
            {
                int number = Int32.Parse(Console.ReadLine());

                try
                {
                    double result = Sqrt(number);
                    Console.WriteLine("The square of {0} is {1} !", number, result);
                }
                catch (ArgumentException nan)
                {
                    Console.WriteLine("Invalid number(negative)!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!\n");
            }
        }
    }
}
