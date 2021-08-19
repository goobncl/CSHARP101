using System;

namespace LATEAST
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using constructor
            Person tom = new Person("Tom", 30);
            // Using deconstructor
            var (name, age) = tom;
            
            Console.WriteLine($"{name}, {age}");
        }
    }
}
