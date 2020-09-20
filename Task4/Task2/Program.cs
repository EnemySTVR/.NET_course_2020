using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
                ("Введите первую строку:");
            string row1 = Console.ReadLine();
            Console.WriteLine
                ("Введите вторую строку:");
            string row2 = Console.ReadLine();
            
            string result = "";
            foreach (var i in row1.ToCharArray())
            {
                if(i != ' ' && row2.ToCharArray().Contains(i))
                {
                    result += i;
                }  

                result += i;
            }
            Console.WriteLine
                ($"Результирующая строка: {result}");
            Console.ReadLine();
        }
    }
}
