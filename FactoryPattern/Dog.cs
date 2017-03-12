namespace FactoryPattern
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name)
        : base(name)
        {
        }

        override public void Eat()
        {
            Console.WriteLine(Name + ": Eating like a dog.");
        }

        override public void Run()
        {
            Console.WriteLine(Name + ": Running like a dog.");
        }

    }
}
