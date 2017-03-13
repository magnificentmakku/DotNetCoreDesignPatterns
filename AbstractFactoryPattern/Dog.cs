namespace AbstractFactoryPattern
{
    public class Dog : Creature
    {
        public Dog(string name, IAnimalPartsFactory animalPartsFactory)
        : base(name)
        {
            _animalPartsFactory = animalPartsFactory;
        }

        public override void MakeCreature()
        {
            _doMove = _animalPartsFactory.CreateDoMove();
            _makeSound = _animalPartsFactory.CreateMakeSound();
        }

        private readonly IAnimalPartsFactory _animalPartsFactory;

    }
}
