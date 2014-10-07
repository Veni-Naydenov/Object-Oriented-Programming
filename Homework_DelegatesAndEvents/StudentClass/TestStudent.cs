namespace StudentClass
{
    using System;

    class TestStudent
    {
        static void Main()
        {
            Student student = new Student("Ivan", 22);
            student.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.PropertyName, eventArgs.OldValue, eventArgs.NewValue);
            };
            student.Name = "Softuncho";
            student.Age = 1;

            Console.WriteLine(new string('-',70));

            Student otherStudent = new Student("Motci", 33);
            otherStudent.PropertyChanged += new PropertyChangedEventHandler(PropChanged);
            otherStudent.Name = "Stoichkov";
            otherStudent.Age = 45;
        }

        private static void PropChanged(object sender,
           PropertyChangedEventArgs eventArgs)
        {
            Console.WriteLine("Property changed: {0} (from {1} to {2})",
               eventArgs.PropertyName, eventArgs.OldValue, eventArgs.NewValue);
        }
    }
}
