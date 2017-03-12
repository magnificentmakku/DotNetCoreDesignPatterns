namespace FactoryPattern
{
    using System;

    public abstract class Animal
    {
        public Animal(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            set;
        }

        public virtual void Eat()
        {
            Console.WriteLine(Name + ": Eating like an animal");
        }

        public virtual void Run()
        {
            Console.WriteLine(Name + ": Running like an Animal");
        }

    }
}
