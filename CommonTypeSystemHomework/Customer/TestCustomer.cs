namespace Customer
{
    using System;
    using System.Collections.Generic;

    class TestCustomer
    {
        static void Main()
        {
            Payment paymentPc = new Payment("PC", 1899);
            Payment paymentOven = new Payment("Oven", 1111);
            Payment paymentBills = new Payment("Bills", 350);
            var payments = new List<Payment>() { paymentPc, paymentOven, paymentBills };

            Customer ivan = new Customer("Ivan",
                "Geshov",
                "Popov",
                8901034546,
                "1000 Sofia, str.Vasil Levski 78",
                "0888223344",
                "Vancho@gmail.com",
                payments,
                Customers.Regular);

            Customer pesho = new Customer("Pesho",
               "Dobrev",
               "Volev",
               8309034116,
               "Kaspichan, str.Hristo Botev 33",
               "0888777777",
               "PeshkoIT@gmail.com",
               payments,
               Customers.Diamond);

            Customer cloning = ivan.Clone();

            Console.WriteLine("{0}\n", ivan.ToString());

            Console.WriteLine("\tCompare Customer Ivan with his deep clone \n" +
                "Ivan == cloning : {0}\n", ivan.CompareTo(cloning) == 0 ? "True" : "False");

            Console.WriteLine("{0}\n", pesho.ToString());

            Console.WriteLine("\tCompare Customer Ivan with Pesho \n" +
               "Ivan == Pesho : {0}\n", ivan.CompareTo(pesho) == 0 ? "True" : "False");

            Console.WriteLine("\tCompare the address of Ivan with the address of Pesho \n" +
                "Ivan address: {0}\nPesho address: {1}\n" +
                "Ivan address == Pesho address : {2}\n",
                ivan.Address,
                pesho.Address,
                ivan.Address.Equals(pesho));
        }
    }
}
