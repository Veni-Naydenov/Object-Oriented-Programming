namespace Animals
{
    using System;

    class Tomcat : Cat, ISound
    {
        public Tomcat(string name,
            decimal age)
            : base(name, age, "Male")
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Muuuuuuurrr.I am tomcat.");
        }
    }
}
