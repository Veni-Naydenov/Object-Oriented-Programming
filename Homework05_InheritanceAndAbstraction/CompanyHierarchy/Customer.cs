namespace CompanyHierarchy
{
    class Customer : Person, IPerson
    {
        private decimal spentMoney = 0;

        public Customer(int id,
            string fName,
            string lName,
            decimal spentMoney)
            : base(id, fName, lName)
        {
            this.SpentMoney = spentMoney;
        }

        public decimal SpentMoney
        {
            get
            {
                return this.spentMoney;
            }
            set
            {
                this.spentMoney = value;
            }
        }
    }
}
