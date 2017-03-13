namespace AbstractFactoryPattern
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            CreatureFactory creatureFactory = new AnimalFactory();
            var tweety = creatureFactory.MakeCreature("bird", "Tweety");
            var spike = creatureFactory.MakeCreature("dog", "spike");

            Console.WriteLine(tweety.DoMove());
            Console.WriteLine(tweety.MakeSound());
            Console.WriteLine(spike.DoMove());
            Console.WriteLine(spike.MakeSound());
        }

    }
}
