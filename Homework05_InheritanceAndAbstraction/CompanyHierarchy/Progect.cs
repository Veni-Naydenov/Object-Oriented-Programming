namespace CompanyHierarchy
{
    using System;

    public class Progect : RegularEmployeeDuty
    {
        private string details = null;
        private string state = null;

        public Progect(string name,
            DateTime date,
            string details)
            : base(name, date)
        {
            this.Details = details;
            this.State = "Open";
        }
        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
            }
        }

        public void CloseProject()
        {
            this.State = "Closed";
        }

        public override string ToString()
        {
            string progect = string.Format(
                "\tProgect\n{0}\n " +
                "Progect Details: {1}\n" +
                "Progect State: {2}",
                base.ToString(),
                this.Details,
                this.State);

            return progect;
        }
    }
}
