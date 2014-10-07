namespace Homework_DelegatesAndEvents
{
    using System;

    class Interest
    {
        public const uint n = 12;

        public static decimal GetSimpleInterest(decimal sum, decimal interest, ushort years)
        {
            decimal result = sum * (1 + (interest / 100) * years);

            return result;
        }

        public static decimal GetCompoundInterest(decimal sum, decimal interest, ushort years)
        {
            decimal result = sum * (decimal)Math.Pow((double)(1 + (interest / 100) / n), years * n);

            return result;
        }

        static void Main()
        {
            Func<decimal, decimal, ushort, decimal> calculateInterest = GetCompoundInterest;
            InterestCalculator compoundInterest = new InterestCalculator(500m, 5.6m, 10, calculateInterest);

            calculateInterest = GetSimpleInterest;
            var simpleInterest = new InterestCalculator(2500m, 7.2m, 15, calculateInterest);

            Console.WriteLine("{0}", compoundInterest.ToString());
            Console.WriteLine("{0}", simpleInterest.ToString());
        }
    }
}
