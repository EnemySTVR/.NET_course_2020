using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет. Лучше смотреть код. Но я покажу тут, что всё работает.");
            Console.WriteLine("Создан DynamicArray. Сейчас он пуст.");
            var array = new DynamicArray();
            Console.WriteLine("Созданы 3 тестовых обьекта. Они пронумерованы.");
            var testObject = new TestObject() { Name = "1" };
            var testObject1 = new TestObject() { Name = "2" };
            var testObject2 = new TestObject() { Name = "3" };
            Console.WriteLine("С помощью метода Add добавляем их поочередно и выводим на экран:");
            array.Add(testObject);
            array.Add(testObject1);
            array.Add(testObject2);
            ShowDynamicArray(array);
            Console.WriteLine("С помощью метода Remove удалим тетовый метод с номером 1.");
            array.Remove(testObject1);
            ShowDynamicArray(array);
            Console.WriteLine("С помощью метода Insert вставим тестовый метод с номером 1 по индексу 1");
            array.Insert(testObject1, 1);
            ShowDynamicArray(array);
            Console.WriteLine("А сейчас создадим и с помощью метода AddRange добавим массив из тех же трёх тестовых объектов.");
            var arr = new object[3] { testObject, testObject1, testObject2 };
            array.AddRange(arr);
            ShowDynamicArray(array);
            Console.ReadLine();
        }

        static void ShowDynamicArray(DynamicArray array)
        {
            foreach (var current in array)
            {
                Console.WriteLine(current);
            }
        }
    }
}
