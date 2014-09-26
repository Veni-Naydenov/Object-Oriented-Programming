namespace _03.SoftUni_LearningSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Main_SoftUniLearningSystem
    {
        static void Main()
        {
            JuniorTrainer juniorTrainer = new JuniorTrainer("Sokol", "Pileshtarov", 19);
            juniorTrainer.CreateCourse("Java");
            juniorTrainer.CreateCourse("C#");
            juniorTrainer.CreateCourse("HTML");

            SeniorTrainer senior = new SeniorTrainer("Super", "Mario", 23);
            senior.CreateCourse("PHP for aliens");
            senior.CreateCourse("JavaScript");
            senior.CreateCourse("CSS");

            senior.DeleteCourse("PHP for aliens");
            senior.DeleteCourse("HTML");
            //// It will throw excepton 
            //senior.DeleteCourse("Pole dance");
            Console.WriteLine();

            CurrentStudent currentSt = new CurrentStudent("Ivan", "Nikolov", 28, 1123, 120, "PHP");
            OnsiteStudent onsiteStudent = new OnsiteStudent("Minka", "Sisharpova", 21, 11236, 300, "C#", 6);
            OnsiteStudent onsiteStudent2 = new OnsiteStudent("Nenko", "Javarov", 25, 2236, 250, "Java", 10);

            OnlineStudent onlineStudent = new OnlineStudent("Hristo", "Barbukov", 23, 1145, 130, "JavaScript");

            GraduateStudent graduatedStudent = new GraduateStudent("Miro", "Mirchev", 26, 1133, 360);

            DropoutStudent dropedStudent = new DropoutStudent("Zoro", "Zorev", 20, 11112, 20, "Too low exam results!");
            dropedStudent.Reapply();

            Console.WriteLine("\nAll courses in SoftUni:");
            foreach (var course in Trainer.Courses)
            {
                Console.WriteLine(course);
            }

            List<Object> listObj = new List<object>();
            listObj.Add(juniorTrainer);
            listObj.Add(senior);
            listObj.Add(currentSt);
            listObj.Add(onsiteStudent);
            listObj.Add(onsiteStudent2);
            listObj.Add(onlineStudent);
            listObj.Add(graduatedStudent);
            listObj.Add(dropedStudent);

            Console.WriteLine(new string('-', 70));
            //Extract only Current Students and sort them by Average Grade
            Console.WriteLine("Extract only Current Students and sort them by Average Grade\n");
            SulsTest.ExtractCurrentStudents(listObj);
        }
    }
}
