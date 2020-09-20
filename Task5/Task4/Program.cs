using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var my_str1 = new MyString("Мама мыла раму.");
            Console.WriteLine
                ($"Строка 1: {my_str1}");
            var my_str2 = new MyString(new char[4]  { 'р', 'а', 'м', 'у'});
            Console.WriteLine
                ($"Строка 2: {my_str2}");


            Console.WriteLine
                ($"Строка 1 + строка 2: {my_str1 + my_str2}");
            Console.WriteLine
                ($"Строка 1 - строка 2: {my_str1 - my_str2}");
            Console.WriteLine
                ($"Строка 1 == строка 2: {my_str1 == my_str2}");
            Console.WriteLine
                ($"Строка 1 != строка 2: {my_str1 != my_str2}");
            Console.ReadLine();
        }
    }
}
