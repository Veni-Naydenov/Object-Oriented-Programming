namespace BankOfKurtovoKonare
{
    using System;

    class Loan : Account, IDepositable
    {
        public Loan(string name,
            Customer typeOfCustomer,
            decimal initialBalance,
            decimal interest)
            : base(name, typeOfCustomer, initialBalance, interest)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentOutOfRangeException("Negativ months are not permitted");
            }

            if (this.CustomerType == Customer.Individual)
            {
                if (months <= 3)
                {
                    return 0;
                }
                else
                {
                    decimal interest = this.Balance *
                    (1 + (this.InterestRate / 100) * (months - 3));

                    return interest;
                }
            }
            else
            {
                if (months <= 2)
                {
                    return 0;
                }
                else
                {
                    decimal interest = this.Balance *
                    (1 + (this.InterestRate / 100) * (months - 2));

                    return interest;
                }
            }
        }
    }
}
