namespace LaptopShop
{
    using System;

    class LaptopShop
    {
        static void Main()
        {
            Laptop laptop1 = new Laptop("Aspire", "Acer");
            Laptop laptop2 = new Laptop("Aspire", "Acer", "Intel i5", "GeFotce GT 650", new Battery("LiIon",3), new Screen("LCD"),1155);
            Laptop laptop3 = new Laptop("IdeaPad", "Lenovo", "Intel i3", "AMD Radeon R5 2GB", new Battery("LiCd", 5), new Screen("LED", 1600, 1200),1050);
            Laptop laptop4 = new Laptop("HP 350 GZ", 999 );

            Laptop[] laptops = new Laptop[4];

            laptops[0] = laptop1;
            laptops[1] = laptop2;
            laptops[2] = laptop3;
            laptops[3] = laptop4;

            int line = 1;
            foreach (var laptop in laptops)
            {
                Console.WriteLine("--{0}--{1}", line, laptop.ToString());
                line++;
            }
        }
    }
}
