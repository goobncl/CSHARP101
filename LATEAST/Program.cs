using System;

namespace LATEAST
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Employee
            {
                Id = 1001,
                Name = "Tom",
                Age = 30
            };

            Console.WriteLine(p1.ToString());
        }
    }
}
