﻿using System;

namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            new Behavioral.Visitor.Client().Main(); // you can specify another pattern
            Console.ReadLine();
        }
    }
}
