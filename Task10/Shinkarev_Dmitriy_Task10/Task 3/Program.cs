using System;
using System.Linq;
using System.Threading;

namespace Task3
{
    class Program
    {
        private const string endSotrMessage = "Сортировка завершена!";

        static void Main(string[] args)
        {
            string[] array = new string[] { "sad", "asd", "das", "wasdwww", "adweqwe", "aw", "aa" };

            Console.WriteLine("Начало сортировки:");
            Sort.EndSortAction += DisplayEndSortMessage;
            Sort.LengthAndAlphavit(array, true);
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Первый поток.");
            }

            foreach (var str in array)
            {
                Console.WriteLine(str);
            }

            Sort.JoinSecondThread();
            Sort.EndSortAction -= DisplayEndSortMessage;
        }

        private static void DisplayEndSortMessage()
        {
            Console.WriteLine(endSotrMessage);
        }
    }
}
