namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new AnimalFactory();
            Animal tweety = factory.CreateAnimale("b", "Tweety");
            Animal spike = factory.CreateAnimale("d", "Spike");

            tweety.Eat();
            tweety.Run();

            spike.Eat();
            spike.Run();
        }
    }
}
