namespace SingletonPattern
{
    using System;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            var singletonA = Singleton.Instance;
            var singletonB = Singleton.Instance;

            Console.WriteLine("singletonA: " + singletonA.GetHashCode());
            Console.WriteLine("singletonB: " + singletonB.GetHashCode());

            ThreadSafeSingleton threadSafeX;
            ThreadSafeSingleton threadSafeY;

            Task<ThreadSafeSingleton> getX = ThreadSafeSingleton.GetInstanceAsync();
            Task<ThreadSafeSingleton> getY = ThreadSafeSingleton.GetInstanceAsync();

            Task.WaitAll(getX, getY);

            threadSafeX = getX.Result;
            threadSafeY = getY.Result;

            Console.WriteLine("threadSafeX: " + threadSafeX.GetHashCode());
            Console.WriteLine("threadSafeY: " + threadSafeY.GetHashCode());
        }

    }
}
