namespace _03.SoftUni_LearningSystem
{
    class CurrentStudent : Student
    {
        private string field = null;

        public CurrentStudent(string firstName, string lastName, uint age, uint studentNumber, ushort averageGrade,string field)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.field = field;
        }

        public string Field
        {
            get
            {
                return this.field;
            }
            set
            {
                this.field = value;
            }
        }
    }
}
