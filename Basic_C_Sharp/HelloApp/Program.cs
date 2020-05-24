using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite Name");
            var Name = Console.ReadLine();
            Console.WriteLine($"Privet {Name}"); ;
            Console.ReadKey();
        }
    }
}
