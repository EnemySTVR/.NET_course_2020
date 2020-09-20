using System;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^([-+]?\d+([.,]\d+)?)$"))
            {
                Console.WriteLine("Это число в обычной нотации.");
            }
            else
            {
                if (Regex.IsMatch(input, @"^([-+]?\d+([.,]\d+)?(e\d+){1})$"))
                {
                    Console.WriteLine("Это число в научной нотации.");
                }
                else
                {
                    Console.WriteLine("Это не число.");
                }
            }
            Console.ReadLine();
        }
    }
}
