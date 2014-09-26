namespace GenericList
{
    using System;

    [VersionAttribute("1.13")]
    class TestGenericList
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(20);

            for (int i = 0; i < 19; i++)
            {
                list.Add(i + 1);
            }
            Console.WriteLine("List Length = {0}", list.Length);
            Console.WriteLine(list.ToString());

            list.Insert(6, 21);
            Console.WriteLine("\nInsert 21 at position 6\n{0}", list.ToString());

            list.RemoveAtPosition(6);
            Console.WriteLine("\nRemove 21 at position 6\n{0}", list.ToString());

            Console.WriteLine("\nAt position 7 is {0}", list[7]);

            Console.WriteLine("Is there value 11 -> {0}", list.Contain(11));
            Console.WriteLine("Is there value 110 -> {0}", list.Contain(110));

            Console.WriteLine("\nThe position of {0} is {1}",
                77, list.Find(delegate(int number) { return number == 77; }));
            Console.WriteLine("The position of {0} is {1}",
                7, list.Find(delegate(int number) { return number == 7; }));

            list.Add(122);
            list.Add(1223);
            Console.WriteLine("\nAfter auto Grow:\nLength={0}\n{1}", list.Length, list.ToString());

            Console.WriteLine("Min value is: {0}", list.Min<int>());
            Console.WriteLine("Max value is: {0}", list.Max<int>());

            list.Clear();
            Console.WriteLine("\nList after Clear(): {0}", list.ToString());
            Console.WriteLine(new string('-', 70));

            var stringList = new GenericList<string>();
            stringList.Add("Html");
            stringList.Add("Java");
            stringList.Add("PHP");
            stringList.Add("CSS");

            Console.WriteLine(stringList.ToString());
            Console.WriteLine("Max string value : {0}", stringList.Max<string>());
            Console.WriteLine("Min string value : {0}", stringList.Min<string>());
            Console.WriteLine(new string('-', 70));

            System.Reflection.MemberInfo info = typeof(TestGenericList);
            //Type type = typeof(TestGenericList);
            object[] attributes = info.GetCustomAttributes(true);

            foreach (VersionAttribute element in attributes)
            {
                Console.WriteLine("Version: {0}\n", element.FullVersion);
            }
        }
    }
}
