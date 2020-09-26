using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Employee
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }

        public Employee(string name)
        {
            _name = name;
        }

        public void Greeting(Employee colleague, DateTime arrivalTime)
        {
            bool morning = arrivalTime.Hour < 12;
            bool evening = arrivalTime.Hour > 17;


            if (morning)
            {
                Say($"{_name} говорит: Доброе утро, {colleague.Name}!");
            }
            else if (evening)
            {
                Say($"{_name} говорит: Добрый вечер, {colleague.Name}!");
            }
            else
            {
                Say($"{_name} говорит: Добрый день, {colleague.Name}!");
            }
        }

        public void Parting(Employee colleague)
        {
            Say($"{_name} говорит: Пока, {colleague.Name}!");
        }
        public void Say(string text)
        {
            Console.WriteLine(text);
        }
    }
}
