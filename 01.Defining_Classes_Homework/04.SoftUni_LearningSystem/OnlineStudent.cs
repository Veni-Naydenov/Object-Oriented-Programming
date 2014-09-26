namespace _03.SoftUni_LearningSystem
{
    class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string firstName, string lastName, uint age, uint studentNumber, ushort averageGrade, string field)
            : base(firstName, lastName, age, studentNumber, averageGrade, field)
        {
        }
    }
}
