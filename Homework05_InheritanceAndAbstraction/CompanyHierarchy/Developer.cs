namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Developer : Employee, IEmployee
    {
        private IList<Progect> progects;

        public Developer(int id,
            string fName,
            string lName,
            Departments department,
            decimal salary,
            IList<Progect> progects)
            : base(id, fName, lName, department, salary)
        {
            this.Progects = progects;
        }

        public IList<Progect> Progects
        {
            get
            {
                return this.progects;
            }
            set
            {
                this.progects = value;
            }
        }

        public override string ToString()
        {
            var info = new StringBuilder();
            info.AppendFormat("\t{0}\n", this.GetType().Name);
            info.Append(base.ToString());

            foreach (var progect in this.Progects)
            {
                info.AppendFormat(
                "{0}\n", progect.ToString());
                info.AppendFormat("\n{0}\n", new string('-', 35));
            }
            info.AppendFormat("\n{0}", new string('#', 50));

            return info.ToString();
        }
    }
}
