using System;
using Library;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
                ("Сейчас мы создадим сотрудника на основе класса пользователя.");
            Console.Write
                ("Введи должность сотрудника: ");
            string position = CorrectInput.Word();
            Console.Write
                ("Введи имя сотрудника: ");
            string firstName = CorrectInput.Word();
            Console.Write
                ("Введи фамилию сотрудника: ");
            string lastName = CorrectInput.Word();
            Console.Write
                ("Введи отчество сотрудника: ");
            string surName = CorrectInput.Word();
            Console.Write
                ("Введи дату рождения сотрудника: ");
            DateTime birth = CorrectInput.DateTime();

            var employee = new Employee(position, firstName, lastName, surName, birth);
            Console.WriteLine
                ($"Отлично! Сотрудник {employee.LastName} {employee.FirstName} {employee.SurName} создан!");
            Console.WriteLine
                ($"Он родился {employee.Date_of_Birth.ToLongDateString()} Ему {employee.Age} лет.");
            Console.WriteLine
                ($"Занимает должность {employee.Position} в течение {employee.LengthOfWork} лет.");
            Console.ReadLine();
        }
    }
}
