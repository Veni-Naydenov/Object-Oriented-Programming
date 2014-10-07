using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student
    {
        private string firstName = null;
        private string lastName = null;
        private int age = 0;
        private int facultyNumber = 0;
        private string phoneNumber = null;
        private string email = null;
        private IList<int> marks;
        private int groupNumber = 0;

        //public Student(string fName, string lName, int age)
        //{
        //    this.FirstName = fName;
        //    this.LastName = lName;
        //    this.Age = age;
        //}

        //public Student(string fName, int facultyNum)
        //    : this(fName, null, 0, facultyNum, null, null, null, 0)
        //{
        //    this.FirstName = fName;
        //    this.FacultyNumber = facultyNum;
        //}

        //public Student(string fName, int groupNum)
        //    : this(fName, null, 0, 0, null, null, null, groupNum)
        //{
        //    this.FirstName = fName;
        //    this.GroupNumber = groupNum;
        //}

        public Student(string fName, string lName, int age, int facultyNum,
            string phone, string email, IList<int> marks, int groupNum)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age;
            this.FacultyNumber = facultyNum;
            this.PhoneNumber = phone;
            this.Email = email;
            this.marks = marks;
            this.GroupNumber = groupNum;
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                this.groupNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }

        public int FacultyNumber
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

        public int Age
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

        public StringBuilder AllMarks
        {
            get
            {
                var allMarks = new StringBuilder();
                foreach (var mark in this.marks)
                {
                    allMarks.AppendFormat(" {0}", mark);
                }
                return allMarks;
            }
        }

        public override string ToString()
        {
            //var allMarks = new StringBuilder();
            //foreach (var mark in this.marks)
            //{
            //    allMarks.AppendFormat(" {0}", mark);
            //}

            string studentInfo = String
                .Format("First Name: {0}\nLast Name: {1}\nAge: {2}\nFaculty Num: {3}\n" +
                "Phone: {4}\nEmail: {5}\nMarks: {6}\nGroup Number: {7} ",
                this.firstName, this.lastName, this.age,
                this.facultyNumber, this.phoneNumber, this.email,
                this.AllMarks, this.groupNumber);

            return studentInfo;
        }
    }
}
