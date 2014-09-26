namespace _01.Persons
{
    using System;
    using System.Text;

    class Person
    {
        private string name = null;
        private uint age = 0;
        private string email = null;

        public Person(string name, uint age)
            : this(name, age, null)
        {

        }

        public Person(string name, uint age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value != null && (!(value.Contains("@") && value.Length > 5)))
                {
                    throw new ArgumentException("Email length must be minimum 5 simbols and containing @");
                }
                this.email = value;
            }
        }

        public uint Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value > 100)
                {
                    throw new ArgumentOutOfRangeException("Invalid age, must be smaller than 101");
                }
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public override string ToString()
        {
            StringBuilder strResult = new StringBuilder();
            strResult.AppendFormat("Name: {0}\n", Name);
            strResult.AppendFormat("Age: {0}\n", Age);
            if (Email != null)
            {
                strResult.AppendFormat("Email: {0}\n", Email);
            }

            return strResult.ToString();
        }
    }
}
