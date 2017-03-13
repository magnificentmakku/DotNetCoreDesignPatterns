namespace AbstractFactoryPattern
{
    public class DogPartsFactory : IAnimalPartsFactory
    {
        public IDoMove CreateDoMove()
        {
            return new MoveWithFourLegs();
        }

        public IMakeSound CreateMakeSound()
        {
            return new Barker();
        }

    }
}
