namespace FactoryPattern
{
    using System;

    public class Bird : Animal
    {
        public Bird(string name)
        : base(name)
        {
        }

        override public void Eat()
        {
            Console.WriteLine(Name + ": Eating like a bird.");
        }

        override public void Run()
        {
            Console.WriteLine(Name + ": Running like a bird.");
        }

    }
}
