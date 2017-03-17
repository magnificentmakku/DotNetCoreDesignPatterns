namespace SingletonPattern
{
    public sealed class Singleton
    {
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();

                return _instance;
            }
        }

        private Singleton()
        {
        }

        private static Singleton _instance;

    }
}
