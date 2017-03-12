namespace StrategyPattern
{
    using System;

    public sealed class CannotFly : IFlyer
    {
        public CannotFly()
        {
        }

        #region IFlyer members

        public void Fly()
        {
            Console.WriteLine("I cannot fly :(");
        }

        #endregion

    }
}
