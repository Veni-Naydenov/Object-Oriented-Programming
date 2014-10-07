namespace BankOfKurtovoKonare
{
    using System;
    using System.Collections.Generic;

    class TestTheBank
    {
        static void Main()
        {
            Deposit depositIndivid = new Deposit("Pesho", Customer.Individual, 7800, 10);
            Deposit depositComp = new Deposit("Soft comp", Customer.Company, 77800, 13);

            Mortgage mortgageIndivid = new Mortgage("Ivan", Customer.Individual, 1000, 6);
            Mortgage mortgageComp = new Mortgage("Karuca Company", Customer.Company, 666666, 20);

            Loan loanIndivid = new Loan("Bobi", Customer.Individual, 5055, 14);
            Loan loanIndivid2 = new Loan("Viki", Customer.Individual, 122, 5);
            Loan loanComp = new Loan("NetSoft", Customer.Company, 100055, 17);

            var accounts = new List<Account>();

            accounts.Add(depositIndivid);
            accounts.Add(depositComp);
            accounts.Add(mortgageIndivid);
            accounts.Add(mortgageComp);
            accounts.Add(loanIndivid);
            accounts.Add(loanIndivid2);
            accounts.Add(loanComp);

            Console.WriteLine("\tInitial Accounts information");
            foreach (var account in accounts)
            {
                Console.WriteLine(account.ToString());
                Console.WriteLine(new string('-', 30));
            }
            Console.WriteLine(new string('#', 50));

            Console.WriteLine("Withdraw 1500.lv from {0} account.", depositIndivid.Name);
            Console.WriteLine("\tAccount after Withdraw");
            depositIndivid.WithdrawMoney(1500);
            Console.WriteLine(depositIndivid.ToString());
            Console.WriteLine(new string('#', 50));

            Console.WriteLine("Deposit 500.lv to {0} account.", loanComp.Name);
            Console.WriteLine("\tAccount after Deposit");
            loanComp.DepositMoney(3500);
            Console.WriteLine(loanComp.ToString());
            Console.WriteLine(new string('#', 50));

            Console.WriteLine("\tDeposit 3000.lv to ALL Accounts");
            foreach (var account in accounts)
            {
                account.DepositMoney(3000);
                Console.WriteLine(account.ToString());
                Console.WriteLine(new string('-', 30));
            }
            Console.WriteLine(new string('#', 50));

            Console.WriteLine("Interest for 13 months for account:\nName: {0}\ntype: {1}",
                mortgageComp.Name, mortgageComp.GetType().Name);
            Console.WriteLine("Interest = {0}.lv", mortgageComp.CalculateInterest(13));
            Console.WriteLine(new string('#', 50));

            Console.WriteLine("Interest for 3 months for account:\nName: {0}\ntype: {1}",
                loanIndivid2.Name, loanIndivid2.GetType().Name);
            Console.WriteLine("Interest = {0}.lv", loanIndivid2.CalculateInterest(3));
            Console.WriteLine(new string('#', 50));
        }
    }
}
