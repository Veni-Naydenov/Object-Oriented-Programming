namespace Animals
{
    using System;

    class Dog : Animal, ISound
    {
        public Dog(string name, decimal age, string gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bark, bark. I am snoop doggy Dog ;).");
        }
    }
}
