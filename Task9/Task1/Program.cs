using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(x + " " + y);

            var h1 = new Human("хуман1 Вася");
            var h2 = new Human("хуман2 Петя");
            var h3 = new Human("хуман3 Арсений");
            var h4 = new Human("хуман4 Витек");
            var h5 = new Human("хуман5 Костян");
            var h6 = new Human("хуман6 Степа");
            var h7 = new Human("хуман7 Коля");


            var cycleList = new List<Human>();
            cycleList.Add(h1);
            cycleList.Add(h2);
            cycleList.Add(h3);
            cycleList.Add(h4);
            cycleList.Add(h5);
            cycleList.Add(h6);
            cycleList.Add(h7);

            var cycleLinkedList = new LinkedList<Human>();
            cycleLinkedList.AddLast(h1);
            cycleLinkedList.AddLast(h2);
            cycleLinkedList.AddLast(h3);
            cycleLinkedList.AddLast(h4);
            cycleLinkedList.AddLast(h5);
            cycleLinkedList.AddLast(h6);
            //cycleLinkedList.AddLast(h7);


            Console.WriteLine("создано добавлено");
            ShowElements(cycleList);
            ShowElements(cycleLinkedList);


            RemoveEachSecondItemList(ref cycleList);
            RemoveEachSecondItemLinked(cycleLinkedList);
            Console.WriteLine("удалено");
            ShowElements(cycleList);
            ShowElements(cycleLinkedList);

            Console.ReadLine();
        }

        static void RemoveEachSecondItemList(ref List<Human> list)
        {
            var temp = new List<Human>();
            if (list.Count > 1)
            {
                foreach (var h in list)
                {
                    if (list.IndexOf(h) % 2 == 0)
                    {
                        temp.Add(h);
                    }

                }
                list = temp;

                if (list.Count % 2 == 0)
                {
                    list.Add(list.First());
                    list.Remove(list.First());
                }

                RemoveEachSecondItemList(ref list);
            }
        }

        

        static void RemoveEachSecondItemLinked(LinkedList<Human> linkedList)
        {
            while (linkedList.Count > 1)
            {
                linkedList.AddLast(linkedList.First());
                linkedList.Remove(linkedList.First());
                linkedList.Remove(linkedList.First());
            }

        }

        static void ShowElements(IEnumerable<Human> list)
        {
            foreach (var h in list)
            {
                Console.WriteLine(h);
            }
        }

    }
}
