namespace HumanStudentWorker
{
    public abstract class Human
    {
        private string firstName = null;
        private string lastName = null;

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
    }
}
