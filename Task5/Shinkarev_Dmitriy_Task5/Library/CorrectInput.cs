using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Library
{
    public class CorrectInput
    {
        public static int Number()
        {
            bool flag = true;
            string input;
            int result = 0;

            var reg = new Regex(@"^([-]?\d+)$");
            do
            {
                input = Console.ReadLine();
                if (reg.IsMatch(input))
                {
                    result = Int32.Parse(input);
                    flag = false;
                }
                else
                    Console.WriteLine("Это должно быть целое число.");
            }
            while (flag == true);
            return result;
        }
        public static int PositiveNumber()
        {
            bool flag = true;
            string input;
            int result = 0;

            var reg = new Regex(@"^\d+$");
            do
            {
                input = Console.ReadLine();
                if (reg.IsMatch(input))
                {
                    result = Int32.Parse(input);
                    flag = false;
                }
                else
                    Console.WriteLine("Это должно быть положительное целое число.");
            }
            while (flag == true);
            return result;
        }
        public static string Word()
        {
            bool flag = true;
            string input;
            var reg = new Regex(@"^(([A-я]+|[^\W0-9_]))$");
            do
            {
                input = Console.ReadLine();
                if (reg.IsMatch(input))
                {
                    flag = false;
                }
                else
                    Console.WriteLine("Слово должно состоять только из букв.");
            }
            while (flag == true);
            return input;
        }
        public static DateTime DateTime()
        {
            DateTime result = new DateTime();
            bool flag;

            do
            {
                try
                {
                    flag = false;
                    result = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Не удалось преобразовать дату. Попробуй снова.");
                    flag = true;
                }
            }
            while (flag == true);
            
            return result;
        }
    }
}
