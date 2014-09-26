namespace ReadNumber
{
    using System;
    using System.Collections.Generic;

    class ReadNumberInRange
    {
        public static string ReadNumber(int start, int end)
        {
            List<int> list = new List<int>();
            int num;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    num = Int32.Parse(Console.ReadLine());
                    if (num <= start || num >= end)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    start = num;
                    list.Add(num);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a number !");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Not in the range ({0}:{1})!", start, end);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number is very big for an int value !");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You have entered empty space!");
                }
            }

            int[] array = list.ToArray();
            string result = string.Join(" ", array);

            return result.ToString();
        }

        private static int MyTryParseEnd(int end)
        {
            try
            {
                if (end > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Have entered invalid number for the End of the range!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number !");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is very big for an int value !");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You have entered empty space!");
            }
            return end;
        }

        private static int MyTryParse(int start)
        {
            try
            {
                if (start < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Have entered invalid number for start of the range!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number !");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is very big for an int value !");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You have entered empty space!");
            }
            return start;
        }

        static void Main()
        {
            int start = 0;
            int end = 0;

            Console.WriteLine("Enter start number for the range: ");
            start = MyTryParse(start = Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the End number for the range: ");
            end = MyTryParseEnd(end = Int32.Parse(Console.ReadLine()));

            int number;
            string sequence = ReadNumber(start, end);

            Console.WriteLine("Correctly inserted sequence is: {0}", sequence);
        }
    }
}
