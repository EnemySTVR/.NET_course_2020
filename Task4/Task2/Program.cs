using System;

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
                foreach(var j in str2.ToCharArray())
                {
                    if(i == j && i != ' ')
                    {
                        res += j;
                        break;
                    }
                }

                res += i;
            }

            Console.WriteLine($"Результирующая строка: {res}");
            Console.ReadLine();
        }
    }
}
