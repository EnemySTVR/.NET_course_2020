using System;
using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            for(int i = 0; i < 1000; i++)
            {
                if(i % 3 == 0 || i % 5 == 0) 
                { 
                    result += i;
                }
            }

            Console.WriteLine($"Сумма всех чисел меньше 1000, кратных 3 или 5 равна {result}.");
            Console.ReadLine();
        }
    }
}
