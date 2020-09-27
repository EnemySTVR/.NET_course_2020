using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new string[] { "asd", "qwe" };
            lol(array);
        }

        static void lol(object obj)
        {
            Console.WriteLine(obj.GetType());
            Console.ReadLine();

        }
    }
}
