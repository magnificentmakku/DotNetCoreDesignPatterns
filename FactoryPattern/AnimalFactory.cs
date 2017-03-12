namespace FactoryPattern
{
    using System;

    public class AnimalFactory
    {
        public AnimalFactory()
        {
        }

        public Animal CreateAnimale(string animalType, string name)
        {
            switch (animalType)
            {
                case "b": return new Bird(name);
                case "d": return new Dog(name);
                default: throw new ArgumentOutOfRangeException("animalType");
            }
        }

    }
}
