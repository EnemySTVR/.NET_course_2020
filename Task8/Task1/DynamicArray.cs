using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace Task1
{
    class DynamicArray : IEnumerable
    {
        // TODO: Сейчас список содержит ссылки на обьекты. Переделать на создание новых объектов при присвоении.

        private int _length = 0;
        private object[] _array;

        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= _length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return _array[index];
            }
        }

        public int Length { 
            get
            {
                return _length;
            }
        }
        public int Capasity
        {
            get
            {
                return _array.Length;
            }
        }
        public DynamicArray()
        {
            _array = new object[8];
        }
        public DynamicArray(int length)
        {
            _array = new object[length];
        }
        public DynamicArray(object[] array)
        {
            foreach (var obj in array)
            {
                Type objType = obj.GetType();
                var constructor = objType.GetConstructor(Type.EmptyTypes);
                if (constructor == null)
                    throw new ArgumentException();
            }
            _array = array;
        }
        /// <summary>
        /// Принимает в качетсве аргумента объект имеющий конструктор по умолчанию и добавляет его в динамический массив.
        /// </summary>
        /// <param name="obj"></param>
        public void Add(object obj)
        {
            Type objType = obj.GetType();
            var constructor = objType.GetConstructor(Type.EmptyTypes);
            if (constructor != null)
            {
                if (_array.Length == _length)
                {
                    var temp = new object[_length + 8];
                    for (int i = 0; i < _array.Length; i++)
                    {
                        temp[i] = _array[i];
                    }
                    _array = temp;
                }
                _array[_length] = obj;
                _length++;
            }
            else 
                throw new ArgumentException();
        }

        /// <summary>
        /// Принимает в качестве аргумента массив объектов имеющих конструктор по умолчанию и добавляет его в динамический массив.
        /// </summary>
        /// <param name="array"></param>
        public void AddRange(object[] array)
        {
            foreach (var obj in array)
            {
                Type objType = obj.GetType();
                var constructor = objType.GetConstructor(Type.EmptyTypes);
                if (constructor == null)
                    throw new ArgumentException();
            }

            var temp = new object[_array.Length + array.Length];
            
            for (int i = 0; i < _length; i++)
            {
                temp[i] = _array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                temp[i + _length] = array[i];
            }

            _array = temp;
            _length += array.Length;
        }

        /// <summary>
        /// Принимает в качестве аргумента объект, удаляет его из динамического списка и возвращает true. Если список не содержит объект, возвращает false.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Remove(object obj)
        {
            bool result = false;
            for (int i = 0; i < _array.Length; i++)
            {
                while (_array[i] == obj)
                {
                    for (int j = i; j < _array.Length - 1; j++)
                    {
                        _array[j] = _array[j + 1];
                        if (j == _array.Length - 2)
                        {
                            _array[j + 1] = null;
                        }
                    }
                    _length--;
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// Принимает в качестве аргументов объект имеющий конструктор по умолчанию и индекс. Вставляет объект в список по указанному индексу. Сдвигает правую часть списка.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="index"></param>
        public void Insert(object obj, int index)
        {
            Type objType = obj.GetType();
            var constructor = objType.GetConstructor(Type.EmptyTypes);
            if (constructor != null)
            {
                if (index < 0 || index >= _length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (_array.Length == _length)
                {
                    var temp = new object[_length + 8];
                    var tmp_index = 0;
                    for (int i = 0; i < _array.Length; i++, tmp_index++)
                    {
                        if (i == index)
                        {
                            temp[i] = obj;
                            tmp_index++;
                        }
                        temp[tmp_index] = _array[i];
                    }
                    _array = temp;
                }

                if (index < _length)
                {
                    for (int i = _length; i > index; i--)
                    {
                        _array[i] = _array[i - 1];
                    }
                }
                

                _array[index] = obj;
                _length++;
            }
            else 
                throw new ArgumentException();
        }

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < _length; index++)
            {
                yield return _array[index];
            }
        }
    }
}
