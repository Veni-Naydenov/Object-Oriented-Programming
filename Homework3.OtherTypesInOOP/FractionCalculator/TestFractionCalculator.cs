namespace FractionCalculator
{
    using System;

    class TestFractionCalculator
    {
        static void Main()
        {

            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction result = fraction1 + fraction2;
            PrintResult(result);

            Fraction fraction3 = new Fraction(22, 7);
            Fraction fraction4 = new Fraction(40, 4);
            Fraction minusResult = fraction3 - fraction4;
            PrintResult(minusResult);
        }

        private static void PrintResult(Fraction fractionResult)
        {
            Console.WriteLine("Numerator = {0}", fractionResult.Numerator);
            Console.WriteLine("Denominator = {0}", fractionResult.Denominator);
            Console.WriteLine("{0}/{1} = {2}\n", fractionResult.Numerator, fractionResult.Denominator, fractionResult);
        }
    }
}
