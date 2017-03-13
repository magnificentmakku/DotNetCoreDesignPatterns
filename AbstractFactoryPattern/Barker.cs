namespace AbstractFactoryPattern
{
    public class Barker : IMakeSound
    {
        public string MakeSound()
        {
            return "Bark bark bark!";
        }

    }
}
