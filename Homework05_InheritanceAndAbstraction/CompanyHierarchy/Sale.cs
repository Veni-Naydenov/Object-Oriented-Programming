namespace CompanyHierarchy
{
    using System;

    public class Sale : RegularEmployeeDuty
    {
        private decimal price = 0;

        public Sale(string name, DateTime date,decimal price)
            : base(name, date)
        {
            this.Price = price;
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public override string ToString()
        {
            string sale = string.Format(
                "\tSale\n{0}\n Sale Price: {1} $\n",
                base.ToString(),
                this.Price);

            return sale;
        }
    }
}
