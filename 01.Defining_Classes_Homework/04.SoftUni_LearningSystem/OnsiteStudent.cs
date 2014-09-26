namespace _03.SoftUni_LearningSystem
{
    class OnsiteStudent : CurrentStudent
    {
        private uint numberOfVisits = 0;

        public OnsiteStudent(string firstName, string lastName, uint age, uint studentNumber, ushort averageGrade, string field, uint numberOfVisits)
            : base(firstName, lastName, age, studentNumber, averageGrade, field)
        {
            this.numberOfVisits = numberOfVisits;
        }

        public uint NumberOfVisits
        {
            get
            {
                return this.numberOfVisits;
            }
            set
            {
                this.numberOfVisits = value;
            }
        }
    }
}
