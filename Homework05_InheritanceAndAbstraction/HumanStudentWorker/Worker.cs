namespace HumanStudentWorker
{
    class Worker : Human
    {
        private decimal weekSalary = 0;
        private int workHoursPerDay = 0;

        public Worker(string fName,
            string lName,
            decimal weekSalary,
            int workHoursPerDay)
        {
            base.FirstName = fName;
            base.LastName = lName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal workHoursPerWeek = 5 * this.workHoursPerDay;
            decimal moneyPerHour = this.WeekSalary / workHoursPerWeek;

            return moneyPerHour;
        }

        public override string ToString()
        {
            string workerInfo = string.Format(
                "First Name: {0}\nLast Name: {1}\nPayment Per Hour: {2}",
                this.FirstName, this.LastName, this.MoneyPerHour());

            return workerInfo;
        }
    }
}
