using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var myRow1 = new MyString("Мама мыла раму.");
            Console.WriteLine
                ($"Строка 1: {myRow1}");
            var myRow2 = new MyString(new char[4]  { 'р', 'а', 'м', 'у'});
            Console.WriteLine
                ($"Строка 2: {myRow2}");


            Console.WriteLine
                ($"Строка 1 + строка 2: {myRow1 + myRow2}");
            Console.WriteLine
                ($"Строка 1 - строка 2: {myRow1 - myRow2}");
            Console.WriteLine
                ($"Строка 1 == строка 2: {myRow1 == myRow2}");
            Console.WriteLine
                ($"Строка 1 != строка 2: {myRow1 != myRow2}");
            Console.ReadLine();
        }
    }
}
