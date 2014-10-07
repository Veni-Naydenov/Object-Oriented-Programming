namespace HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TestHumanStudentWorker
    {
        static void Main()
        {
            Student roni = new Student("Roni", "Bozov", "12345HPZ");
            Student djoni = new Student("Djoni", "Nikov", "32945HZ");
            Student ivan = new Student("Ivan", "Vazov", "3366RPS");
            Student lili = new Student("Lili", "Lizova", "4456JKK");
            Student krisi = new Student("Krisi", "Ivanova", "5698KRSI");
            Student milen = new Student("Milen", "Petkov", "7281MPK");
            Student john = new Student("John", "Silver", "99945JJSS");
            Student udi = new Student("Udi", "Alan", "7788UDI");
            Student richi = new Student("Richi", "Richmond", "99999USS");
            Student liza = new Student("Liza", "Mishpekova", "6969CSS");

            var listOfStudents = new List<Student>() 
            { roni, djoni, ivan, lili, krisi,
                milen, john, udi, richi, liza };

            var sortedByFacultyNum = listOfStudents.OrderBy(st => st.FacultyNumber);

            Console.WriteLine("\tSorted by faculty number in ascending order ");
            foreach (var student in sortedByFacultyNum)
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine(new string('-', 30));
            }
            Console.WriteLine(new string('#', 50));

            Worker pesho = new Worker("Pesho", "Peskata", 1200, 6);
            Worker ivo = new Worker("Ivo", "Ivanov", 1500, 8);
            Worker silvi = new Worker("Silvi", "Silver", 2200, 10);
            Worker hristo = new Worker("Hristo", "Nakov", 3000, 6);
            Worker dimo = new Worker("Dimo", "Padalski", 3500, 8);
            Worker arnold = new Worker("Arnold", "Negrov", 500, 4);
            Worker silvia = new Worker("Silvia", "Sisileva", 5000, 8);
            Worker Jivko = new Worker("Jivko", "Ernandov", 2680, 5);
            Worker nikita = new Worker("Nikita", "Sweethardova", 6500, 9);
            Worker mimi = new Worker("Mimi", "Mishkova", 1000, 4);

            var listOfWorkers = new List<Worker>()
            { pesho, ivo, silvi, hristo, dimo,
                arnold, silvia, Jivko, nikita, mimi };

            var sortedByPayment = listOfWorkers
                .OrderByDescending(worker => worker.MoneyPerHour());

            Console.WriteLine("\tWorkers sorted by payment per hour in descending order");
            foreach (var worker in sortedByPayment)
            {
                Console.WriteLine(worker.ToString());
                Console.WriteLine(new string('-', 30));
            }
            Console.WriteLine(new string('#', 50));

            var mergedLists = new List<Human>();
            mergedLists.AddRange(listOfStudents);
            mergedLists.AddRange(listOfWorkers);

            var mergedListSortedByNames = mergedLists
                .OrderBy(human => human.FirstName)
                .ThenBy(human => human.LastName);

            Console.WriteLine("\tMerge the lists and then sort them by first name and last name");
            foreach (var human in mergedListSortedByNames)
            {
                Console.WriteLine(human.GetType().Name);
                Console.WriteLine(human.ToString());
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}