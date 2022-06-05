using System;

namespace T2108A1
{
    class lab27
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("In 15 years, age of " + name + " will be " + (age + 15));
        }
    }
}