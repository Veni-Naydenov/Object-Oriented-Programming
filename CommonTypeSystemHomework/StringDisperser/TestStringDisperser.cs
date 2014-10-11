namespace StringDisperser
{
    using System;

    class TestStringDisperser
    {
        static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();

            StringDisperser disperser = new StringDisperser("Misho", "Mimi", "Lili", "Vania");
            Console.WriteLine("Second disperser: {0}", disperser.ToString());

            Console.WriteLine("\n\tCompare the two string dispersers\n" +
                "Result: {0}", stringDisperser.CompareTo(disperser));
            Console.WriteLine("\n\tCompare the two string dispersers with ==\n" +
               "Result: {0}", stringDisperser == disperser);
            Console.WriteLine("\n\tCompare the two string dispersers with Equals\n" +
                "Result: {0}", stringDisperser.Equals(disperser));

            var cloning = disperser.Clone();
            Console.WriteLine("\tCompare disperser with his deep clone \n" +
                "Result: {0}", disperser.CompareTo(cloning));
        }
    }
}
