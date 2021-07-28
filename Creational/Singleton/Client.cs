using System;

namespace DesignPatterns.Creational.Singleton
{
    public class Client
    {
        /*
         * Singleton pattern ensures that there is only one instance of the 
         * class.
         *
         * Also ensures a single access point for all code.
         */
        public void Main()
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            Console.WriteLine(s1 == s2 ? "Singleton works!" : "Singleton bad!");
        }
    }
}
