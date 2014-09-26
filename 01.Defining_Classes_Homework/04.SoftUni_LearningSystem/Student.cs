namespace _03.SoftUni_LearningSystem
{
    class Student : Person
    {
        private uint studentNumber = 0;
        private ushort averageGrade = 0;

        public Student(string firstName, string lastName, uint age, uint studentNumber, ushort averageGrade)
            : base(firstName, lastName, age)
        {
            this.studentNumber = studentNumber;
            this.averageGrade = averageGrade;
        }

        public ushort AverageGrade
        {
            get
            {
                return this.averageGrade;
            }
            set
            {
                this.averageGrade = value;
            }
        }

        public uint StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                this.studentNumber = value;
            }
        }
    }
}
