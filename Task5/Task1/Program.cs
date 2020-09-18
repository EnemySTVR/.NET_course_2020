using Library;
using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name;
            string last_name;
            string sur_name;
            DateTime birth;

            Console.WriteLine("Сейчас мы создадим пользователя.");
            Console.Write("Введи имя пользователя: ");
            first_name = CorrectInput.Word();
            Console.Write("Введи фамилию пользователя: ");
            last_name = CorrectInput.Word();
            Console.Write("Введи отчество пользователя: ");
            sur_name = CorrectInput.Word();
            Console.Write("Введи дату рождения пользователя в формате ДД.ММ.ГГГГ: ");
            birth = CorrectInput.DateTime();


            var user = new User(first_name, last_name, sur_name, birth);

            Console.WriteLine();

            Console.WriteLine($"Отлично! Пользователь {user.LastName} {user.FirstName} {user.SurName} создан!");
            Console.WriteLine($"Он родился {user.Date_of_Birth.ToLongDateString()} Ему {user.Age} лет.");
            Console.ReadLine();
        }

    }
}
