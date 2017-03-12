namespace StrategyPattern
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var spike = new Dog("Spike");
            var tweety = new Bird("Tweety");

            Console.WriteLine("Spike tries to fly...");
            spike.Fly();

            Console.WriteLine("Tweety tries to fly...");
            tweety.Fly();

            Console.WriteLine("Teaching Spike how to fly...");
            spike.Flyer = new CanFly();

            Console.WriteLine("Spike tries to fly again...");
            spike.Fly();
        }

    }
}
