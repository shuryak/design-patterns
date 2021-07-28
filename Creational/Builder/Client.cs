using System;
using DesignPatterns.Creational.Builder.Builders;

namespace DesignPatterns.Creational.Builder
{
    /*
     * Builder is pattern that let to construct COMPLEX object STEP BY STEP.
     *
     * Builder encapsulates the inner realization inside and provides an 
     * interface for constructing.
     */
    public class Client
    {
        public void Main(string[] args)
        {
            Director director = new Director();
            ConcreteBuilder builder = new ConcreteBuilder();
            
            director.Builder = builder;
            
            Console.WriteLine("Minimal viable product (Provided by Director):");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Full featured product (Provided by Director):");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());
            
            // Director is optional component
            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.Write(builder.GetProduct().ListParts());
        }
    }
}
