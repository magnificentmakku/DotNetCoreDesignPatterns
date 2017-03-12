namespace StrategyPattern
{
    using System;

    public abstract class Animal
    {
        public Animal(string name, IFlyer flyer)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Must not be null or empty.", "name");
            if (flyer == null)
                throw new ArgumentNullException("flyer");

            Name = name;
            Flyer = flyer;
        }

        public IFlyer Flyer
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public void Fly()
        {
            Console.Write(Name + ": ");
            Flyer.Fly();
        }

    }
}
