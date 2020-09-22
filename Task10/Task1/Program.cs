using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        delegate void SortStringArray(string[] array, int overlapLength, int currentIndex);
        static void Main(string[] args)
        {
            string[] array = new string[] { "sad", "asd", "das", "wasdwww", "adweqwe", "aw", "aa" };
            Console.WriteLine("До сортировки:");
            foreach (var str in array)
            {
                Console.WriteLine(str);
            }

            SortStringArray sortDelegate = null;
            sortDelegate += AlphavitSortInLengthSorr;

            LenghtAndAlphavitSort(ref array, sortDelegate);

            // Профита в этом действии я не увидел, но, говорят, хороший тон.
            sortDelegate -= AlphavitSortInLengthSorr;

            Console.WriteLine("После сортировки:");
            foreach (var str in array)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }


        private static void LenghtAndAlphavitSort(ref string[] array, SortStringArray sortDelegate)
        {
            array = array.OrderBy(x => x.Length).ToArray();

            int overlapLength = 0;
            int previousLength = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (previousLength == array[i].Length)
                {
                    overlapLength++;
                    if (i == array.Length - 1)
                    {
                        overlapLength++;
                        sortDelegate(array, overlapLength, i + 1);
                    }
                }
                else if (overlapLength > 0)
                {
                    overlapLength++;
                    sortDelegate(array, overlapLength, i);
                    overlapLength = 0;
                }
                previousLength = array[i].Length;
            }
        }


        private static void AlphavitSortInLengthSorr(string[] array, int overlapLength, int currentIndex)
        {
            int startOverlapIndex = currentIndex - overlapLength;
            var tempArray = new string[overlapLength];

            for (int j = 0; j < overlapLength; j++, startOverlapIndex++)
            {
                tempArray[j] = array[startOverlapIndex];
            }

            // Возврат индекса в исходное положение.
            startOverlapIndex -= overlapLength;

            Array.Sort(tempArray);

            for (int j = 0; j < overlapLength; j++, startOverlapIndex++)
            {
                array[startOverlapIndex] = tempArray[j];
            }
        }
    }
}
