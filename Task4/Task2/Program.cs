using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;
            string res = "";
            Console.WriteLine("Введите первую строку:");
            str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку:");
            str2 = Console.ReadLine();

            foreach(var i in str1.ToCharArray())
            {
                if(i != ' ' && str2.ToCharArray().Contains(i))
                {
                    res += i;
                }  

                res += i;
            }

            Console.WriteLine($"Результирующая строка: {res}");
            Console.ReadLine();
        }
    }
}
