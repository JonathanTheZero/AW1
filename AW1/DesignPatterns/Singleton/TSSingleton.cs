namespace AW1.DesignPatterns.Singleton
{
    //Thread Safe Singleton
    public sealed class TSSingleton
    {
        private static volatile TSSingleton singleton;

        private static object syncRoot = new object();

        private TSSingleton() { }

        public static TSSingleton GetInstance()
        {
            lock (syncRoot)
            {
                if (singleton == null)
                {
                    singleton = new TSSingleton();
                }
                return singleton;
            }
        }
    }

    public sealed class TSSingleton2
    {
        private static readonly TSSingleton2 instance = new TSSingleton2();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static TSSingleton2() { }

        private TSSingleton2() { }

        public static TSSingleton2 Instance => instance;
    }
}
