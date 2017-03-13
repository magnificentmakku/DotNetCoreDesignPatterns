namespace AbstractFactoryPattern
{
    public interface IAnimalPartsFactory
    {
        IDoMove CreateDoMove();

        IMakeSound CreateMakeSound();

    }
}
