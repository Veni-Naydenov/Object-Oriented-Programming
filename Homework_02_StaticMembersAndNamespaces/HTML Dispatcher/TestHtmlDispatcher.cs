namespace HtmlDispatcher
{
    using System;

    class TestHtmlDispatcher
    {
        static void Main()
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAtribute("class", "wrapper");
            div.AddAtribute("id", "test");
            div.AddContent("<p>test contend 1</p>");
            div.AddContent("<span>test contend 2</span>");

            int multiplier = 3;

            Console.WriteLine(div);
            Console.WriteLine("\tMultiply the element by {0}\n", multiplier);
            Console.WriteLine(div * multiplier);

            //Test HTML Dispatcher
            Console.WriteLine("\tTest HTML Dispatcher\n");

            string image = HTMLDispatcher.CreateImage("imgs/funkyCode.jpg", "funny pic", "funny image");
            Console.WriteLine("\nImage:\n{0}", image);

            string hyperlink = HTMLDispatcher.CreateURL("https://softuni.bg/", "SoftUni", "Visit SOFTWARE UNIVERSITY");
            Console.WriteLine("\nurl:\n{0}", hyperlink);

            string input = HTMLDispatcher.CreateInput("text", "username", "OOP Ninja");
            Console.WriteLine("\nInput:\n{0}", input);
        }
    }
}
