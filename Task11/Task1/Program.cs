
using MyLibrary;
using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 3;
            Console.WriteLine($"Возьмем число {number}.");
            Console.WriteLine($"Возведем его в Третью степень: {MyMath.Exponentiation(number, 3)}.");
            Console.WriteLine($"И вычислим его факториал: {MyMath.Factorial(number)}");

            Console.ReadKey();
        }
    }
}
