namespace Homework_DelegatesAndEvents
{
    using System;

    class InterestCalculator
    {
        private decimal interestResult = 0;
        private decimal money = 0;
        private decimal interest = 0;
        private ushort years = 0;
        private readonly string type = null;

        public InterestCalculator(decimal money, decimal interest, ushort years,
            Func<decimal, decimal, ushort, decimal> func)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.type = (func.Method.Name).Substring(3);
            this.InterestResult = func(Money, Interest, Years);
        }

        public ushort Years
        {
            get
            {
                return this.years;
            }
            private set
            {
                this.years = value;
            }
        }

        public decimal Interest
        {
            get
            {
                return this.interest;
            }
            private set
            {
                this.interest = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                this.money = value;
            }
        }

        public decimal InterestResult
        {
            get
            {
                return this.interestResult;
            }
            private set
            {
                this.interestResult = value;
            }
        }

        public override string ToString()
        {
            string result = string.
                Format("Money: {0}\nInterest: {1}\nYears: {2}\nType: {3}\nResult: {4}\n",
                this.Money, this.Interest, this.Years, this.type, this.InterestResult);

            return result.ToString();
        }
    }
}
