//5.Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students
// by first name and last name in descending order. Rewrite the same with LINQ.
using System;
using System.Linq;

namespace _05.OrderByAndLinQ
{
    class Student
    {
        private string firstName;
        private string lastName;
        private byte age;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public byte Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }
    }
    class OrderByAndLinQ
    {
        private static void SortStudents(Student[] students)
        {
            var sorted = students. 
                                OrderByDescending(student => student.FirstName).
                                ThenByDescending(student => student.LastName);

            Console.WriteLine("\nSorted students :");
            PrintResult(sorted);
        }

        private static void PrintResult(IOrderedEnumerable<Student> sorted)
        {
            int index = 1;
            foreach (var name in sorted)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}:", index++);
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        private static void LinQSorted(Student[] students)
        {
            var linqSorted =
                from Student stud in students
                orderby stud.FirstName descending, stud.LastName descending
                select stud;
            Console.WriteLine("\nSorted by LinQ :");
            PrintResult(linqSorted);
        }

        static void Main()
        {
            Student[] students = new Student[6];
            string[] firstNames = { "Pesho", "Ivan", "Kosta", "Iva", "Kocho", "Aa" };
            string[] lastNames = { "Kocev", "Kolev", "Tsonev", "Zorova", "Mocho", "Bb" };
            byte[] age = { 11, 19, 23, 18, 21, 24 };

            for (int i = 0; i < 6; i++)
            {
                students[i] = new Student();
                students[i].FirstName = firstNames[i];
                students[i].LastName = lastNames[i];
                students[i].Age = age[i];
            }

            int index = 1;
            Console.WriteLine("All available students: ");
            foreach (Student name in students)
            {
                Console.Write("{0}: ", index++);
                Console.WriteLine(name.FirstName + " " + name.LastName + ", " + name.Age + " years old");
            }

            SortStudents(students); // Using the extension methods OrderBy() and ThenBy()

            LinQSorted(students);// sorted by order  with LINQ
        }
    }
}
