namespace StrategyPattern
{
    public class Bird : Animal
    {
        public Bird(string name)
        : base(name, new CanFly())
        {
        }

        public Bird(string name, IFlyer flyer)
        : base(name, flyer)
        {
        }

    }
}
