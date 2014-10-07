namespace StringBuilderExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class TestExtensions
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            text.Append("Lorem ipsum dolor sit amet lorem, ex pro cetero LoreM senserit appellantur, in mei legere nonumes fuisset");
            string subStr = text.Substring(3, 6);
            Console.WriteLine(subStr);

            Console.WriteLine("\nold text:\n{0}\n", text.ToString());

            text.RemoveText("Lorem");
            Console.WriteLine("Removed: Lorem\nNew text:\n{0}", text);

            var list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i + 1);
            }

            text.AppendAll(list);
            Console.WriteLine(text);
            //overrided with 2 parametars 
            text.AppendAll(list, ", ");
            Console.WriteLine(text);
        }
    }
}
