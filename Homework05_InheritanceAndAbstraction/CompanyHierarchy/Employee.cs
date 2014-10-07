namespace CompanyHierarchy
{
    using System;

    public abstract class Employee : Person, IPerson, IEmployee
    {
        private decimal salary = 0;
        private Departments department;

        public Employee(int id,
            string fName,
            String lName,
            Departments department,
            decimal salary)
            : base(id, fName, lName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }

        public Departments Department
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = value;
            }
        }

        public override string ToString()
        {
            string employeeInfo = string.Format(
                "Id: {0}\n" +
                "First Name: {1}\n" +
                "Last Name: {2}\n" +
                "Department: {3}\n" +
                "Salary: {4} EUR\n",
                this.Id,
                this.FirstName,
                this.LastName,
                this.Department,
                this.Salary);

            return employeeInfo;
        }
    }
}
