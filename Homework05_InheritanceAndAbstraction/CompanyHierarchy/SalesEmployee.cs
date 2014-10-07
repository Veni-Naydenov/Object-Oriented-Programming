namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SalesEmployee : Employee, IEmployee
    {
        private IList<Sale> sales;

        public SalesEmployee(int id,
            string fName,
            string lName,
            Departments department,
            decimal salary,
            IList<Sale> sales)
            : base(id, fName, lName, department, salary)
        {
            this.Sales = sales;
        }

        public IList<Sale> Sales
        {
            get
            {
                return this.sales;
            }
            set
            {
                this.sales = value;
            }
        }

        public override string ToString()
        {
            var info = new StringBuilder();
            info.AppendFormat("\t{0}\n", this.GetType().Name);
            info.AppendFormat("{0}\n", base.ToString());

            foreach (var sale in this.Sales)
            {
                info.AppendFormat(
                "{0}\n", sale.ToString());
                info.AppendFormat("\n{0}\n", new string('-', 35));
            }
            info.AppendFormat("\n{0}\n", new string('#', 50));

            return info.ToString();
        }
    }
}
