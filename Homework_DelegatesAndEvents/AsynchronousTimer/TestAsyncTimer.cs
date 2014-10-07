namespace AsynchronousTimer
{
    using System;

    class TestAsyncTimer
    {
        public static void Task(string strParam)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(strParam + " by Task 1");
        }

        public static void OtherTask(string strParam)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(strParam + " by Task 2");
        }

        static void Main()
        {

            AsyncTimer timer = new AsyncTimer(Task, 10, 1000);
            timer.Start();

            AsyncTimer timer2 = new AsyncTimer(OtherTask, 10, 500);
            timer2.Start();

        }
    }
}
