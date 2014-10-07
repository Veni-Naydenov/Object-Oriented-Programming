namespace School
{
    using System;
    using System.Collections.Generic;

    class TestSchool
    {
        static void Main()
        {
            Student ivan = new Student("Ivan", 123456, "18 years old.");
            Student maria = new Student("Maria", 123331);
            Student gosho = new Student("Gosho", 333456);
            Student misho = new Student("Misho", 333333);
            Student pesho = new Student("Pesho", 333666, "Pesho javata!");

            ivan.AddDetails("Ivan lives in Sofia.");
            //Console.WriteLine(ivan.ToString());

            var students = new List<Student>();
            students.Add(ivan);
            students.Add(maria);
            students.Add(gosho);

            var disciplines = new List<Discipline>();
            disciplines.Add(new Discipline("PHP", 20, students, "SoftUni PHP 2014."));
            disciplines.Add(new Discipline("Java", 10, students));

            Teacher vlado = new Teacher("Vlado", disciplines);

            disciplines.Add(new Discipline("JavaScript", 40, students, "SoftUni JavaScript 2014.Become a script Ninja"));
            disciplines.Add(new Discipline("KickBox_C#", 5, students, "Become a C# Ninja and Survive ;) !"));
            Teacher nakov = new Teacher("Nakov", disciplines, "Master Ioda - Code Ninja.");

            var teachers = new List<Teacher>() { nakov, vlado };
            // Console.WriteLine(nakov.ToString());

            Class theClass = new Class("May 2014", teachers);

            Console.WriteLine(theClass.ToString());
        }
    }
}
