namespace AW1.DesignPatterns.Model
{
    public class Singleton
    {
        private static Singleton singleton;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (singleton == null)
            {
                singleton = new Singleton();
            }
            return singleton;
        }
    }
}
