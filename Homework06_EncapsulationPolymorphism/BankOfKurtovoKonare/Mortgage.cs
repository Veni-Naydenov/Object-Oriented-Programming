namespace BankOfKurtovoKonare
{
    using System;

    class Mortgage : Account, IDepositable
    {
        public Mortgage(string name,
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

            if (this.CustomerType == Customer.Company)
            {
                if (months <= 12)
                {
                    decimal interest = this.Balance *
                        (1 + (this.InterestRate / 100) * (months));

                    return interest / 2;
                }
                else
                {
                    decimal interest = this.Balance *
                        (1 + (this.InterestRate / 100) * (12));

                    interest = interest / 2 +
                        this.Balance *
                           (1 + (this.InterestRate / 100) * (months - 12));

                    return interest;
                }
            }
            else
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    decimal interest = this.Balance *
                    (1 + (this.InterestRate / 100) * (months - 6));

                    return interest;
                }
            }
        }
    }
}
