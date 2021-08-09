using System;

namespace DesignPatterns.Behavioral.Iterator
{
    /*
     * Pattern Iterator encapsulates data structure inner traversal logic, providing an easy interface for clients
     */
    public class Client
    {
        public void Main()
        {
            WordsCollection collection = new WordsCollection();
            
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            foreach (string element in collection)
            {
                Console.WriteLine(element);
            }

            collection.ReverseDirection();

            foreach (string element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
