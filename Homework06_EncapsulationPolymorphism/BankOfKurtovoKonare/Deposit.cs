namespace BankOfKurtovoKonare
{
    using System;

    class Deposit : Account, IDepositable, IWithdrawable
    {
        public Deposit(string name,
            Customer typeOfCustomer,
            decimal initialBalance,
            decimal interest)
            : base(name, typeOfCustomer, initialBalance, interest)
        {
        }

        public void WithdrawMoney(decimal sum)
        {
            if (this.Balance > sum)
            {
                this.Balance -= sum;
            }
            else
            {
                Console.WriteLine("Not enought money!\n" +
                    "Your balance is {0} .lv", this.Balance);
            }
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentOutOfRangeException("Negativ months are not permitted");
            }

            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                decimal interest = this.Balance *
                    (1 + (this.InterestRate / 100) * months);

                return interest;
            }
        }
    }
}
