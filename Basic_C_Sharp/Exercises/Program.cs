﻿using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercises1
            //Console.WriteLine("Number 1");
            //var Num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Number 2");
            //var Num2 = Convert.ToDouble(Console.ReadLine());
            //if (Num1==Num2)
            //{
            //    Console.WriteLine("два числа =");
            //}
            //else 
            //    if (Num1<Num2)
            //    {
            //        Console.WriteLine("первое число < второго");
            //    }
            //    else
            //    {
            //        Console.WriteLine("первое число > второго");
            //    }
            #endregion

            #region Exercises2
            //Console.WriteLine("Vvedite Number");
            //var Num = Convert.ToDouble(Console.ReadLine());
            //if (Num>5 && Num<10)
            //{
            //    Console.WriteLine("Число > 5 и < 10");
            //}
            //else
            //{
            //    Console.WriteLine("Неизвестное число");
            //}
            #endregion
            #region Exercises3
            //Console.WriteLine("Vvedite Number");
            //var Num = Convert.ToDouble(Console.ReadLine());
            //if (Num == 5 || Num == 10)
            //{
            //    Console.WriteLine("Число == 5 или == 10");
            //}
            //else
            //{
            //    Console.WriteLine("Неизвестное число");
            //}
            #endregion
            #region Exercises4
            //Console.WriteLine("Vvedite Amount");
            //var Num = Convert.ToDouble(Console.ReadLine());
            //if (Num < 100)
            //{
            //    Console.WriteLine($"New = {Num+Num*0.05}");
            //}
            //else
            //{
            //    if (Num >= 100 && Num <= 200)
            //    {
            //        Console.WriteLine($"New = {Num + Num * 0.07}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"New = {Num + Num * 0.1}");
            //    }
            //}
            #endregion
            #region Exercises5
            //Console.WriteLine("Vvedite Amount");
            //var Num = Convert.ToDouble(Console.ReadLine());
            //double Sum = 0;
            //if (Num < 100)
            //{
            //    Sum += Num + Num * 0.05;
            //}
            //else
            //{
            //    if (Num >= 100 && Num <= 200)
            //    {
            //        Sum += Num + Num * 0.07;
            //    }
            //    else
            //    {
            //        Sum += Num + Num * 0.1;
            //    }
            //}
            //Sum += 15;
            //Console.WriteLine($"New = {Sum}");
            #endregion
            #region Exercises6
            //Console.WriteLine("Vyberite operaciu:");
            //Console.WriteLine("1 - \"+\"");
            //Console.WriteLine("2 - \"-\"");
            //Console.WriteLine("3 - \"*\"");
            //var Num = Convert.ToInt32(Console.ReadLine());
            //string Oper = "";
            //switch(Num)
            //{
            //    case 1:
            //        {
            //            Oper = "+";
            //            break;
            //        }
            //    case 2:
            //        {
            //            Oper = "-";
            //            break;
            //        }
            //    case 3:
            //        {
            //            Oper = "*";
            //            break;
            //        }
            //    default:
            //        {
            //            Oper = "HZ";
            //            break;
            //        }
            //}
            //Console.WriteLine(Oper);
            #endregion
            #region Exercises7
            Console.WriteLine("Vvedite Number 1");
            var Num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vvedite Number 2");
            var Num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vyberite operaciu:");
            Console.WriteLine("1 - \"+\"");
            Console.WriteLine("2 - \"-\"");
            Console.WriteLine("3 - \"*\"");
            var NumOper = Convert.ToInt32(Console.ReadLine());
            double? Sum = 0;
            switch (NumOper)
            {
                case 1:
                    {
                        Sum += Num1 + Num2;
                        break;
                    }
                case 2:
                    {
                        Sum += Num1 - Num2;
                        break;
                    }
                case 3:
                    {
                        Sum += Num1 * Num2;
                        break;
                    }
                default:
                    {
                        Sum = null;
                        break;
                    }
            }
            Console.WriteLine(Sum);
            #endregion
        }
    }
}
