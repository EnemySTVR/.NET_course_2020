using System;
using System.Text.RegularExpressions;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Я посчитаю сколько раз было упомянуто время.");
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            var matches = Regex.Matches(input, @"\d{1,2}:{1}\d{2}");
            int count = 0;
            foreach (var m in matches)
            {
                var temp = m.ToString();
                var values = Regex.Matches(temp, @"\d+");
                var value1 = Int32.Parse(values[0].ToString());
                var value2 = Int32.Parse(values[1].ToString());
                if(value1 < 24 && value2 < 60)
                {
                    count++;
                }
            }
            Console.WriteLine($"Время в тексте присутствует {count} раз.");
            Console.ReadLine();
        }
    }
}
