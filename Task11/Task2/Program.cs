using System;
using Task1;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ivan1 = new Employee(
                "midle",
                "Ivan",
                "Sidorov",
                "Petrovich",
                DateTime.Parse("16 10 1990"));

            var ivan2 = new Employee(
                "midle",
                "Ivan",
                "Sidorov",
                "Petrovich",
                DateTime.Parse("16 10 1990"));

            var peter = new Employee(
                "midle",
                "Peter",
                "Sidorov",
                "Ivanovich",
                DateTime.Parse("12 4 1989"));

            Console.WriteLine("Иван 1 равен Ивану 2. Это тот же самый Иван хранящийся в другой части кучи.");
            Console.WriteLine(ivan1.Equals(ivan2));

            Console.WriteLine("Но иван не равен Пете. Петя и Иван - совершенно разные люди.");
            Console.WriteLine(ivan1.Equals(peter));

            Console.ReadKey();


        }
    }
}
