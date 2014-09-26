namespace _03.SoftUni_LearningSystem
{
    using System;

    class DropoutStudent : Student
    {
        private string dropoutReason = null;

        public DropoutStudent(string firstName, string lastName, uint age, uint studentNumber, ushort averageGrade)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
        }

        public DropoutStudent(string firstName, string lastName, uint age, uint studentNumber, ushort averageGrade, string dropoutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.dropoutReason = dropoutReason;
        }

        public string DropoutReason
        {
            get
            {
                return this.dropoutReason;
            }
            set
            {
                this.dropoutReason = value;
            }
        }


        public void Reapply()
        {
            Console.WriteLine("Dropout student Info:");
            Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}", this.FirstName, this.LastName, this.Age);
            Console.WriteLine("Dropout Reason: {0}", this.dropoutReason);
        }
    }
}
