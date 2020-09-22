using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var humans = new Human[]
            {
                new Human("Васян"),
                new Human("Петя"),
                new Human("Арсений"),
                new Human("Витек"),
                new Human("Костян"),
                new Human("Степыч"),
                new Human("Колямба")
            };

            var cycleList = new List<Human>(humans);
            var cycleLinkedList = new LinkedList<Human>(humans);

            Console.WriteLine("Встаньте дети в круг:");
            ShowElements(cycleList);
            ShowElements(cycleLinkedList);
                        
            Console.WriteLine("Считаем по кругу и удаляем каждого второго, пока не останется всего один:");
            cycleList = (List<Human>)RemoveEachSecondItem(cycleList);
            cycleLinkedList = (LinkedList<Human>)RemoveEachSecondItem(cycleLinkedList);
            ShowElements(cycleList);
            ShowElements(cycleLinkedList);

            Console.ReadLine();
        }

        static IEnumerable<Human> RemoveEachSecondItem(IEnumerable<Human> senderList)
        {
            switch (senderList)
            {
                case List<Human> list:
                    {
                        int counter = 0;

                        while (list.Count > 1)
                        {
                            var temp = new List<Human>();
                            foreach (var h in list)
                            {
                                if (counter % 2 == 0)
                                {
                                    temp.Add(h);
                                }
                                counter++;
                            }

                            list = temp;
                        }

                        return list;
                    }
                case LinkedList<Human> linkedList:
                    {
                        while (linkedList.Count > 1)
                        {
                            linkedList.AddLast(linkedList.First());
                            linkedList.Remove(linkedList.First());
                            linkedList.Remove(linkedList.First());
                        }
                        return linkedList;
                    }
                default:
                    {
                        return senderList;
                    }         
            }
        }

        static void ShowElements(IEnumerable<Human> list)
        {
            Console.WriteLine(list.GetType().Name + ":");
            foreach (var h in list)
            {
                Console.WriteLine(h);
            }
        }

    }
}
