namespace FractionCalculator
{
    using System;

    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long inputNumerator, long inputDenominator)
            : this()
        {
            long gcd = GreatestCommonDivisor(inputNumerator, inputDenominator);
            this.Numerator = inputNumerator / gcd;
            this.Denominator = inputDenominator / gcd;

            if (this.denominator < 0)
            {
                this.numerator = -numerator;
                this.denominator = -denominator;
            }
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }
            set
            {
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("denominator can Not be zero");
                }
                this.denominator = value;
            }
        }

        private static long GreatestCommonDivisor(
        long firstNumber, long secondNumber)
        {
            firstNumber = Math.Abs(firstNumber);
            secondNumber = Math.Abs(secondNumber);

            while (firstNumber > 0)
            {
                long newNumber = secondNumber % firstNumber;
                secondNumber = firstNumber;
                firstNumber = newNumber;
            }
            return secondNumber;
        }


        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            long num = f1.numerator * f2.denominator +
                f2.numerator * f1.denominator;
            long denom = f1.denominator * f2.denominator;

            return new Fraction(num, denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long num = f1.numerator * f2.denominator -
                f2.numerator * f1.denominator;
            long denom = f1.denominator * f2.denominator;

            return new Fraction(num, denom);
        }

        public override string ToString()
        {
            decimal result = (decimal)this.Numerator / this.Denominator;

            return result.ToString();
        }
    }
}
