namespace Animals
{
    using System;

    class Kitten : Cat, ISound
    {
        public Kitten(string name,
            decimal age)
            : base(name, age, "Female")
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miau, miau. I am kitty.");
        }
    }
}
