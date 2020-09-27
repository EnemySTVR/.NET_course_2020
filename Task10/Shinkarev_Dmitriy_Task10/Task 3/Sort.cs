using System;
using System.Linq;
using System.Threading;

namespace Task3
{
    static class Sort
    {
        

        private delegate void AlphavitSortInLengthSortDelegate(string[] array, int overlapLength, int currentIndex);
        public static event Action EndSortAction;

        private static Thread secondThread = new Thread(new ParameterizedThreadStart(CasedSort));

        public static void JoinSecondThread()
        {
            secondThread.Join();
        }

        public static void LengthAndAlphavit(string[] array, bool isNewThread)
        {
            if (isNewThread)
            {
                secondThread.Start(array);
            }
            else
            {
                CasedSort(array);
            }
        }

        // Данный метод является оберткой для того, чтобы передать метод LenghtAndAlphavitSort
        // делегату ParameterizedThreadStart, т.к последний принимает только один аргумент типа object.
        private static void CasedSort(object array)
        {
            switch (array)
            {
                case string[] _array:
                    {
                        AlphavitSortInLengthSortDelegate myDelegate = null;
                        myDelegate += AlphavitSortInLengthSort;
                        LenghtAndAlphavitSort(array as string[], myDelegate);
                        myDelegate -= AlphavitSortInLengthSort;
                        EndSortAction?.Invoke();

                        // Цикл создан для того, чтобы наглядно показать то, 
                        // что метод сортировки выполняется действительно параллельно основному потоку.
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("Второй поток.");
                        }

                    }
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        private static void LenghtAndAlphavitSort(string[] array, AlphavitSortInLengthSortDelegate myDelegate)
        {
            var temp = array.OrderBy(x => x.Length).ToArray();

            // цикл ищет элементы в массиве с одинаковой длинной и сортирует их методом переданным делегатом
            for (int i = 0; i < temp.Length; i++)
            {
                int previousLength = 0;
                int overlapLength = 0;
                bool lastElement = i == temp.Length - 1;

                if (previousLength == temp[i].Length)
                {
                    overlapLength++;
                    if (lastElement)
                    {
                        overlapLength++;
                        myDelegate(temp, overlapLength, i + 1);
                    }
                }
                else if (overlapLength > 0)
                {
                    overlapLength++;
                    myDelegate(temp, overlapLength, i);
                    overlapLength = 0;
                }
                previousLength = temp[i].Length;
                Array.Copy(temp, array, array.Length);
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
