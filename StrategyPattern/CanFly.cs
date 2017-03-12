namespace StrategyPattern
{
    using System;

    public sealed class CanFly : IFlyer
    {
        public CanFly()
        {
        }

        #region IFlyer members

        public void Fly()
        {
            Console.WriteLine("I am flying :)");
        }

        #endregion
    }
}
