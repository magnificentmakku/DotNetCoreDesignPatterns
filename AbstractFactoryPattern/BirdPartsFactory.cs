namespace AbstractFactoryPattern
{
    public class BirdPartsFactory : IAnimalPartsFactory
    {
        public IDoMove CreateDoMove()
        {
            return new MoveWithTwoWings();
        }

        public IMakeSound CreateMakeSound()
        {
            return new Tweeter();
        }

    }
}
