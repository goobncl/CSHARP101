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
            Person tom2 = tom1 with { Age = 40 };
            
            string s1 = tom1.Age.ToString();
            string s2 = tom2.Age.ToString();
            
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
