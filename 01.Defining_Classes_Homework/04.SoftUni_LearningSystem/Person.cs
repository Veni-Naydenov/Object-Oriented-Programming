namespace _03.SoftUni_LearningSystem
{
    using System;
    using System.Linq;

    class Person
    {
        private string firstName = null;
        private string lastName = null;
        private uint age = 0;

        public Person(string firstName, string lastName, uint age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public uint Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

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
