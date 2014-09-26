namespace GenericList
{
    using System;
   

    [VersionAttribute("1.11")]

    class TestVersionAttribute
    {
        static void Main()
        {
            Type type = typeof(TestVersionAttribute);
            object[] attributes = type.GetCustomAttributes(false);


            foreach (VersionAttribute element in attributes)
            {
                Console.WriteLine("Version: {0}", element.FullVersion);
            }
        }
    }
}
