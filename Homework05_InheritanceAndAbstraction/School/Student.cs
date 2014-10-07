namespace School
{
    public class Student : People
    {
        private int classNumber;

        public Student(string name, int classNumber, string details = null)
        {
            base.Name = name;
            this.ClassNumber = classNumber;
            base.Details = details;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            string studentInfo = string.Format(
                "\tStudent Name: {0}\n\tClass Number: {1}\n\tStudent Details: {2}",
                this.Name, this.ClassNumber, this.Details);

            return studentInfo;
        }
    }
}
