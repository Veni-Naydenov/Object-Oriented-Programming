namespace _01.Persons
{
    using System;

    class Persons
    {
        static void Main()
        {
            Person person1 = new Person("Milen", 25);
            Console.WriteLine(person1.ToString());

            Person person2 = new Person("Vasil", 33, "vasko@abv");
            Console.WriteLine(person2.ToString());

            Person person3 = new Person("Kristina", 18, "Kris@gmail");
            Console.WriteLine(person3.ToString());
            ////Exceptions
            //Person person4 = new Person("Kristina", 13, "K@");
            //Console.WriteLine(person4.ToString());
            //Person person5 = new Person("Masha", 133, "babaMasha@ru");
            //Console.WriteLine(person5.ToString());
        }
    }
}
