namespace CompanyHierarchy
{
    using System;

    public abstract class RegularEmployeeDuty
    {
        private string name = null;
        private DateTime date;

        public RegularEmployeeDuty(string name, DateTime date)
        {
            this.Name = name;
            this.Date = date;
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

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public override string ToString()
        {
            string employeeDuty = string.Format(
                "Name: {0}\n" +
                "Date: {1}\n",
                this.Name,
                this.Date);

            return employeeDuty;
        }
    }
}
