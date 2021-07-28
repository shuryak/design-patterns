using System;

namespace DesignPatterns.Creational.Prototype
{
    public class Client
    {
        /*
         * Prototype is a pattern that allows clone objects.
         */
        public void Main()
        {
            Person p1 = new Person()
            {
                BirthDate = Convert.ToDateTime("2000-07-02"),
                Name = "John Doe",
                Id = new IdInfo(1)
            };
            
            Person p2 = p1.ShallowCopy();
            
            Person p3 = p1.DeepCopy();

            Console.WriteLine("p1:");
            DisplayValues(p1);
            Console.WriteLine("p2:");
            DisplayValues(p2);
            Console.WriteLine("p3:");
            DisplayValues(p3);
            
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");

            p1.BirthDate = DateTime.Now;
            p1.Name = "John Copy";
            p1.Id.IdNumber = 777;
            
            Console.WriteLine("p1 (after changing p1):");
            DisplayValues(p1);
            Console.WriteLine("p2 (after changing p1):");
            DisplayValues(p2);
            Console.WriteLine("p3 (after changing p1):");
            DisplayValues(p3);
        }
        
        private static void DisplayValues(Person p)
        {
            Console.WriteLine("\tName: {0}, BirthDate: {1:dd.MM.yyyy}", p.Name, p.BirthDate);
            Console.WriteLine("\tID: {0:d}", p.Id.IdNumber);
        }
    }
}
