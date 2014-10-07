using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare
{
    public abstract class Account : IDepositable
    {
        private string name = null;
        private Customer customerType;
        private decimal balance = 0;
        private decimal interestRate = 0;

        protected Account(string name,
            Customer typeOfCustomer,
            decimal initialBalance,
            decimal interest)
        {
            this.Name = name;
            this.CustomerType = typeOfCustomer;
            this.Balance = initialBalance;
            this.InterestRate = interest;
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }

        public Customer CustomerType
        {
            get
            {
                return this.customerType;
            }
            set
            {
                this.customerType = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public abstract decimal CalculateInterest(int months);

        public void DepositMoney(decimal sum)
        {
            this.Balance += sum;
        }

        public override string ToString()
        {
            string info = string.Format(
                "Name: {0}\n" +
                "Customer Type: {1}\n" +
                "Balance: {2} .lv\n" +
                "Interest Rate: {3} %\n",
                this.Name,
                this.CustomerType,
                this.Balance,
                this.InterestRate);

            return info;
        }
    }
}
