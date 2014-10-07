namespace School
{
    using System;
    using System.Text;

    public abstract class Detail
    {
        private string details = null;

        public string Details
        {
            get
            {
                return this.details;
            }
            protected set
            {
                this.details = value;
            }
        }

        public string AddDetails(string newDatail)
        {
            StringBuilder details = new StringBuilder();

            details.AppendFormat("{0}/ {1}", this.Details, newDatail);

            this.Details = details.ToString();

            return this.Details;
        }
    }
}
