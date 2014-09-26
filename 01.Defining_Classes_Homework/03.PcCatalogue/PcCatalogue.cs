namespace _02.PcCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PcCatalogue
    {
        static void Main()
        {
            Computer pc1 = new Computer("Lenovo");
            pc1.AddComponent(new Component("procesor", 223.5, "Intel i5"));
            pc1.AddComponent(new Component("motherboard", 333.5, "Asus"));
            pc1.AddComponent(new Component("graphics card", 120.30, "Nvidia"));
            pc1.SumTotalPrice(pc1.Components);

            Computer pc2 = new Computer("Acer");
            pc2.AddComponent(new Component("procesor", 190.36, "AMD"));
            pc2.AddComponent(new Component("motherboard", 250, "GYGABITE"));
            pc2.AddComponent(new Component("graphics card", 200.90, "AMD RADEON"));
            pc2.SumTotalPrice(pc2.Components);

            Computer pc3 = new Computer("Apple MacBook Pro");
            pc3.AddComponent(new Component("procesor", 500, "Intel i7"));
            pc3.AddComponent(new Component("motherboard", 250, "GYGABITE"));
            pc3.AddComponent(new Component("graphics card", 450, "Nvidia GForce "));
            pc3.SumTotalPrice(pc3.Components);

            List<Computer> computers = new List<Computer>();
            computers.Add(pc1);
            computers.Add(pc2);
            computers.Add(pc3);
            // Sort by price Ascending
            var ascendingSortedComputers = computers.OrderBy(pc => pc.TotalPrice);
            Console.WriteLine("SORTED ASCENDING !");
            PrintInfo(ascendingSortedComputers);

            Console.WriteLine(new string('-', 80));

            var descendingSortedComputers = computers.OrderByDescending(pc => pc.TotalPrice);
            Console.WriteLine("SORTED DESCENDING !");
            PrintInfo(descendingSortedComputers);
        }

        private static void PrintInfo(IOrderedEnumerable<Computer> sortedComputers)
        {
            foreach (var pc in sortedComputers)
            {
                pc.DisplayPcInfo();
                Console.WriteLine(new string('#', 40));
            }
        }
    }
}
