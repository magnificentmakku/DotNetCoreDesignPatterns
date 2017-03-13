namespace AbstractFactoryPattern
{
    public class AnimalFactory : CreatureFactory
    {
        protected override Creature CreateTheCreature(string creatureType, string name)
        {
            switch (creatureType)
            {
                case "bird": return new Bird(name, new BirdPartsFactory());
                case "dog": return new Dog(name, new DogPartsFactory());
                default: return null;
            }
        }

    }
}
