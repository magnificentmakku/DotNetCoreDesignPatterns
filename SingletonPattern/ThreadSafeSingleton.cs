namespace SingletonPattern
{
    using System.Threading;
    using System.Threading.Tasks;

    public sealed class ThreadSafeSingleton
    {
        public static ThreadSafeSingleton GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    if (_isFirstThread)
                    {
                        _isFirstThread = false;
                        Thread.Sleep(1000);
                    }

                    _instance = new ThreadSafeSingleton();
                }
            }
            return _instance;
        }

        public static async Task<ThreadSafeSingleton> GetInstanceAsync()
        {
            return await Task.Run(() => GetInstance());
        }

        private ThreadSafeSingleton()
        {
        }

        private static ThreadSafeSingleton _instance;
        private static bool _isFirstThread = true;
        private static object _lock = new object();

    }
}
