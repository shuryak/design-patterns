namespace Singleton
{
    public class Singleton
    {
        private Singleton() { } // Disable "new" operator

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            
            return _instance;
        }
        
        // Singleton should define some business logic
        public static int RunBusinessLogic()
        {
            return 2 * 2;
        }
    }
}
