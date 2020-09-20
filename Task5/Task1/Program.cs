using Library;
using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сейчас мы создадим пользователя.");
            Console.Write("Введи имя пользователя: ");
            string firstName = CorrectInput.Word();
            Console.Write("Введи фамилию пользователя: ");
            string lastName = CorrectInput.Word();
            Console.Write("Введи отчество пользователя: ");
            string surName = CorrectInput.Word();
            Console.Write("Введи дату рождения пользователя в формате ДД.ММ.ГГГГ: ");
            var birth = CorrectInput.Date();

            var user = new User(firstName, lastName, surName, birth);
            Console.WriteLine($"Отлично! Пользователь {user.LastName} {user.FirstName} {user.SurName} создан!");
            Console.WriteLine($"Он родился {user.Date_of_Birth.ToLongDateString()} Ему {user.Age} лет.");
            Console.ReadLine();
        }

    }
}
