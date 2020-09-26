using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        delegate void AlphavitSortInLengthSortDelegate(string[] array, int overlapLength, int currentIndex);
        static void Main(string[] args)
        {
            string[] array = new string[] { "sad", "asd", "das", "wasdwww", "adweqwe", "aw", "aa" };
            Console.WriteLine("До сортировки:");
            WriteArray(array);

            AlphavitSortInLengthSortDelegate myDelegate = null;
            myDelegate += AlphavitSortInLengthSort;

            LenghtAndAlphavitSort(ref array, myDelegate);

            // Профита в этом действии я не увидел, но, говорят, хороший тон.
            myDelegate -= AlphavitSortInLengthSort;

            Console.WriteLine("После сортировки:");
            WriteArray(array);

            Console.ReadKey();
        }
        private static void WriteArray(string[] array)
        {
            foreach (var str in array)
            {
                Console.WriteLine(str);
            }
        }

        private static void LenghtAndAlphavitSort(ref string[] array, AlphavitSortInLengthSortDelegate myDelegate)
        {
            array = array.OrderBy(x => x.Length).ToArray();

            // цикл ищет элементы в массиве с одинаковой длинной и сортирует их методом переданным делегатом
            for (int i = 0; i < array.Length; i++)
            {
                int previousLength = 0;
                int overlapLength = 0;
                bool lastElement = i == array.Length - 1;

                if (previousLength == array[i].Length)
                {
                    overlapLength++;
                    if (lastElement)
                    {
                        overlapLength++;
                        myDelegate(array, overlapLength, i + 1);
                    }
                }
                else if (overlapLength > 0)
                {
                    overlapLength++;
                    myDelegate(array, overlapLength, i);
                    overlapLength = 0;
                }
                previousLength = array[i].Length;
            }
        }

        private static void AlphavitSortInLengthSort(string[] array, int overlapLength, int currentIndex)
        {
            int startOverlapIndex = currentIndex - overlapLength;
            var tempArray = new string[overlapLength];

            Array.Copy(array, startOverlapIndex, tempArray, 0, overlapLength);
            Array.Sort(tempArray);
            tempArray.CopyTo(array, startOverlapIndex);
            
        }
    }
}
