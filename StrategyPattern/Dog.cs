namespace StrategyPattern
{
    public class Dog : Animal
    {
        public Dog(string name)
        :base(name, new CannotFly())
        {            
        }
        
        public Dog(string name, IFlyer flyer)
        : base(name, flyer)
        {
        }

    }
}
