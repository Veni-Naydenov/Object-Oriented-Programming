using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class TestCompany
    {
        static void Main()
        {
            Sale sale1 = new Sale("PC", new DateTime(2014, 10, 13), 636m);
            Sale sale2 = new Sale("Software", new DateTime(2014, 03, 07), 5600m);
            Sale sale3 = new Sale("Car", new DateTime(2013, 07, 11), 6000m);
            var salesList = new List<Sale>() { sale1, sale2, sale3 };

            Employee eIvan = new SalesEmployee(1,
                "Ivan",
                "Petrov",
                Departments.Sales,
                1500,
                salesList);

            var progect1 = new Progect(".Net",
                new DateTime(2014, 10, 06),
                "OOP course");
            var progect2 = new Progect("PHP",
                new DateTime(2014, 09, 15),
                "PHP course. The COOL thing!");
            var progectList = new List<Progect>() { progect1, progect1 };

            Employee ePesho = new Developer(2,
               "Pesho",
               "Softuerov",
               Departments.Production,
               4500,
               progectList);

            var employees = new List<Employee>() { eIvan, ePesho };

            Manager manager = new Manager(3,
                "Marto",
                "Masterov",
                Departments.Marketing,
                6000,
                employees);

            var people = new List<Person>();
            people.AddRange(employees);
            people.Add(manager);


            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }

        }
    }
}
