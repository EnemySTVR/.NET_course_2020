using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Task1
{
    class DynamicArray<T> : IEnumerable<T> where T : new()
    {
        private int _length = 0;
        private T[] _array;

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

        public int Length
        {
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
            _array = new T[8];
        }
        public DynamicArray(int length)
        {
            _array = new T[length];
        }

        public DynamicArray(IEnumerable<T> array)
        {
            _array = new T[array.Count() * 2];
            foreach (var obj in array)
            {
                Add(obj);
            }
        }
        /// <summary>
        /// Принимает в качетсве аргумента объект имеющий конструктор по умолчанию и добавляет его в динамический массив.
        /// </summary>
        /// <param name="obj"></param>
        public void Add(T obj)
        {
            Insert(obj, _length);
        }

        /// <summary>
        /// Принимает в качестве аргумента массив объектов имеющих конструктор по умолчанию и добавляет его в динамический массив.
        /// </summary>
        /// <param name="array"></param>
        public void AddRange(T[] array)
        {
            foreach (var obj in array)
            {
                Type objType = obj.GetType();
                var constructor = objType.GetConstructor(Type.EmptyTypes);
                if (constructor == null)
                    throw new ArgumentException();
            }

            var temp = new T[_array.Length + array.Length];

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
        public bool Remove(T obj)
        {
            bool result = false;
            for (int i = 0; i < _length; i++)
            {
                while (_array[i].Equals(obj))
                {
                    for (int j = i; j < _length - 1; j++)
                    {
                        _array[j] = _array[j + 1];
                        if (j == _array.Length - 2)
                        {
                            _array[j + 1] = default(T);
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
        public void Insert(T obj, int index)
        {
            _length++;
            if ((index < 0 || index >= _length) && _length != 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (_array.Length == _length)
            {
                var temp = new T[_length + 8];
                var tempIndex = 0;
                for (int i = 0; i < _array.Length; i++, tempIndex++)
                {
                    if (i == index)
                    {
                        temp[i] = obj;
                        tempIndex++;
                    }
                    temp[tempIndex] = _array[i];
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
           
        }

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < _length; index++)
            {
                yield return _array[index];
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (int index = 0; index < _length; index++)
            {
                yield return _array[index];
            }
        }
    }
}
