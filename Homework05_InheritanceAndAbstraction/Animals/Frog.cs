namespace Animals
{
    using System;

    class Frog : Animal, ISound
    {
        public Frog(string name, decimal age, string gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Quak, kvak...");
        }
    }
}
