using System;

namespace ConsoleRW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite Name");
            var Name = Console.ReadLine();
            Console.WriteLine("Vvedite age");
            var Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vvedite height");
            var Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vvedite Salary");
            var Salary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Name - {Name}, Age - {Age}, Height - {Height}, Salary - {Salary}");
        }
    }
}
