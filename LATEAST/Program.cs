using System;

namespace LATEAST
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom1 = new Person
            {
                Name = "Tom",
                Age = 30
            };
            Person tom2 = tom1 with { Age = 30 };
            
            bool same = tom1.Equals(tom2);
            bool b = ReferenceEquals(tom1, tom2);
            Console.WriteLine(same);
            Console.WriteLine(b);
        }
    }
}
