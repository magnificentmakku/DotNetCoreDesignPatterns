namespace AbstractFactoryPattern
{
    public class Tweeter : IMakeSound
    {
        public string MakeSound()
        {
            return "Tweet tweet!";
        }

    }
}
