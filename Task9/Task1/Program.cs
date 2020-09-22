using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var h1 = new Human("хуман1 Вася");
            var h2 = new Human("хуман2 Петя");
            var h3 = new Human("хуман3 Арсений");
            var h4 = new Human("хуман4 Витек");
            var h5 = new Human("хуман5 Костян");
            var h6 = new Human("хуман6 степа");
            var h7 = new Human("хуман7 Коля");

            var cycle = new Cycle();
            cycle.Add(h1);
            cycle.Add(h2);
            cycle.Add(h3);
            cycle.Add(h4);
            cycle.Add(h5);
            cycle.Add(h6);
            //cycle.Add(h7);

            Console.WriteLine("создано добавлено");
            cycle.ShowElements();

            cycle.RemoveEachSecondItemLinked();
            Console.WriteLine("удалено");
            cycle.ShowElements();

            Console.ReadLine();
        }

    }
}
