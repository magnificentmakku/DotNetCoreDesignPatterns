namespace SingletonPattern
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var instanceA = Singleton.Instance;
            var instanceB = Singleton.Instance;

            Console.WriteLine("instanceA: " + instanceA.GetHashCode());
            Console.WriteLine("instanceB: " + instanceB.GetHashCode());
        }

    }
}
