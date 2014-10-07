namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Manager : Employee, IManager
    {
        private IList<Employee> employees;

        public Manager(int id,
            string fName,
            string lName,
            Departments department,
            decimal salary,
            IList<Employee> employees)
            : base(id, fName, lName, department, salary)
        {
            this.Employees = employees;
        }

        public IList<Employee> Employees
        {
            get
            {
                return this.employees;
            }
            set
            {
                this.employees = value;
            }
        }

        public override string ToString()
        {
            var info = new StringBuilder();
            info.AppendFormat("\tManager\n");
            info.Append(base.ToString());
            info.AppendFormat(
               "\n\tEmployee under {0} commands\n\n", this.FirstName);

            foreach (var employee in this.Employees)
            {
                info.AppendFormat(
                "{0}\n", employee.ToString());
            }

            return info.ToString();
        }
    }
}
