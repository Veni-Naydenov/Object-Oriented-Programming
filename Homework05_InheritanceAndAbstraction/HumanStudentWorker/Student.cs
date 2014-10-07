namespace HumanStudentWorker
{
    class Student : Human
    {
        private string facultyNumber = null;

        public Student(string fName, string lName, string facultyNum)
        {
            base.FirstName = fName;
            base.LastName = lName;
            this.FacultyNumber = facultyNum;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            string studentInfo = string.Format(
                "First Name: {0}\nLast Name: {1}\nFaculty Number: {2}",
                this.FirstName, this.LastName, this.FacultyNumber);

            return studentInfo;
        }
    }
}
