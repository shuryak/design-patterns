using System;

namespace Singleton
{
    internal static class Program
    {
        /*
         * Singleton pattern ensures that there is only one instance of the 
         * class.
         *
         * Also ensures a single access point for all code.
         */
        private static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works!");
            }
            else
            {
                Console.WriteLine("Singleton bad!");
            }
        }
    }
}
