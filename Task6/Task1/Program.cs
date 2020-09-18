using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string position;
            string first_name;
            string last_name;
            string sur_name;
            DateTime birth;

            Console.WriteLine("Сейчас мы создадим сотрудника на основе класса пользователя.");
            Console.Write("Введи должность сотрудника: ");
            position = Console.ReadLine();
            Console.Write("Введи имя сотрудника: ");
            first_name = Console.ReadLine();
            Console.Write("Введи фамилию сотрудника: ");
            last_name = Console.ReadLine();
            Console.Write("Введи отчество сотрудника: ");
            sur_name = Console.ReadLine();
            Console.Write("Введи дату рождения сотрудника: ");
            birth = Convert.ToDateTime(Console.ReadLine());



            var employee = new Employee(position, first_name, last_name, sur_name, birth);

            Console.WriteLine();

            Console.WriteLine($"Отлично! Сотрудник {employee.LastName} {employee.FirstName} {employee.SurName} создан!");
            Console.WriteLine($"Он родился {employee.Date_of_Birth.ToLongDateString()} Ему {employee.Age} лет.");
            Console.WriteLine($"Занимает должность {employee.Position} в течение {employee.Length_of_work} лет.");
            Console.ReadLine();
        }
    }
}
