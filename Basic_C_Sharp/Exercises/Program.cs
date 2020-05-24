using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercises1
            Console.WriteLine("Number 1");
            var Num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Number 2");
            var Num2 = Convert.ToDouble(Console.ReadLine());
            if (Num1==Num2)
            {
                Console.WriteLine("два числа =");
            }
            else 
                if (Num1<Num2)
                {
                    Console.WriteLine("первое число < второго");
                }
                else
                {
                    Console.WriteLine("первое число > второго");
                }
            #endregion
        }
    }
}
