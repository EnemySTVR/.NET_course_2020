using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет. Лучше смотреть код. Но я покажу тут, что всё работает.");
            Console.WriteLine("Создан DynamicArray. Сейчас он пуст.");
            var dm = new DynamicArray();
            Console.WriteLine("Созданы 3 тестовых обьекта. Они пронумерованы.");
            var to = new Test_object();
            var to1 = new Test_object1();
            var to2 = new Test_object2();


            Console.WriteLine("С помощью метода Add добавляем их поочередно и выводим на экран:");
            dm.Add(to);
            dm.Add(to1);
            dm.Add(to2);
            ShowDynamicArray(dm);
            
            Console.WriteLine("С помощью метода Remove удалим тетовый метод с номером 1.");
            dm.Remove(to1);
            ShowDynamicArray(dm);

            Console.WriteLine("С помощью метода Insert вставим тестовый метод с номером 1 по индексу 1");
            dm.Insert(to1, 1);
            ShowDynamicArray(dm);

            Console.WriteLine("А сейчас создадим и с помощью метода AddRange добавим массив из тех же трёх тестовых объектов.");
            var arr = new object[3] { to, to1, to2 };
            dm.AddRange(arr);
            ShowDynamicArray(dm);


            Console.ReadLine();
        }

        static void ShowDynamicArray(DynamicArray dm)
        {
            foreach (var o in dm)
            {
                Console.WriteLine(o);
            }
        }
    }
}
