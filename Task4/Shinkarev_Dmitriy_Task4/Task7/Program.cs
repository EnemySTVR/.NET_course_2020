using System;
using System.Text.RegularExpressions;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int count = 0;
            Console.WriteLine("Я посчитаю сколько раз было упомянуто время.");
            Console.WriteLine("Введите строку:");
            input = Console.ReadLine();

            var matches = Regex.Matches(input, @"\d{1,2}:{1}\d{2}");


            foreach (var m in matches)
            {
                var temp = m.ToString();
                var values = Regex.Matches(temp, @"\d+");
                var value_1 = Int32.Parse(values[0].ToString());
                var value_2 = Int32.Parse(values[1].ToString());
                if(value_1 < 24 && value_2 < 60)
                {
                    count++;
                }
            }
            Console.WriteLine($"Время в тексте присутствует {count} раз.");
            Console.ReadLine();
        }
    }
}
