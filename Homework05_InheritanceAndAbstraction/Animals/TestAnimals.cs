namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TestAnimals
    {
        static void Main()
        {   ////Simple test
            //Cat kitty = new Kitten("Kiki", 12);
            //Console.WriteLine(kitty.ToString());

            var cats = new List<Animal>();
            cats.Add(new Kitten("Kiki", 0.5m));
            cats.Add(new Tomcat("Koko", 1.5m));
            cats.Add(new Tomcat("Roko", 3.5m));
            cats.Add(new Kitten("Fufi", 0.3m));
            cats.Add(new Kitten("Jufi", 2.3m));

            var dogs = new List<Animal>();
            dogs.Add(new Dog("Reks", 5.5m, "Male"));
            dogs.Add(new Dog("Roxsana", 1.5m, "Female"));
            dogs.Add(new Dog("Oskar", 0.7m, "Male"));
            dogs.Add(new Dog("Roni", 8.7m, "Male"));

            var frogs = new List<Animal>();
            frogs.Add(new Frog("Frodo", 1.1m, "Male"));
            frogs.Add(new Frog("Frodita", 7.1m, "Female"));
            frogs.Add(new Frog("Ronaldo", 30m, "Female"));

            var animals = new List<Animal>();
            animals.AddRange(cats);
            animals.AddRange(dogs);
            animals.AddRange(frogs);

            var animalsSortedByAge = animals.OrderBy(an => an.Age);

            Console.WriteLine("\tAnimals sortedby Age");

            foreach (var animal in animalsSortedByAge)
            {
                Console.WriteLine(animal.ToString());
                Console.Write("Sound: ");
                animal.ProduceSound();
                Console.WriteLine(new string('-', 15));
            }

            Console.WriteLine("\tAverage Age");
            Console.WriteLine("{0}s average age: {1}", cats[0].GetType().BaseType.Name, GetAverageAge(cats));

            var kittensAverageAge = cats.Where(cat => cat is Kitten).Average(kt => kt.Age);
            Console.WriteLine("Kittens average age: {0}", kittensAverageAge);
            var tomcatsAverageAge = cats.Where(cat => cat is Tomcat).Average(kt => kt.Age);
            Console.WriteLine("Tomcats average age: {0}", tomcatsAverageAge);

            Console.WriteLine("{0}s average age: {1}", dogs[0].GetType().Name, GetAverageAge(dogs));
            Console.WriteLine("{0}s average age: {1}", frogs[0].GetType().Name, GetAverageAge(frogs));
        }

        private static decimal GetAverageAge(List<Animal> animal)
        {
            var averageAge = animal.Average(an => an.Age);

            return averageAge;
        }
    }
}
