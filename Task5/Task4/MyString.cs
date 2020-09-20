using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class MyString : ICollection
    {
        
        private char[] _array;
        public char this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }

        public MyString(char[] array)
        {
            _array = array;
        }
        public MyString(string row)
        {
            _array = row.ToCharArray();
        }

        public static MyString operator +(MyString rowLeft, MyString rowRight)
        {
            int newCount = rowLeft.Count + rowRight.Count;
            char[] result = new char[newCount];

            for (int i = 0; i < rowLeft.Count; i++)
            {
                result[i] = rowLeft[i];
            }

            int addedArrayIndex = 0;
            for (int i = rowLeft.Count; i < newCount; i++, addedArrayIndex++)
            {
                result[i] = rowRight[addedArrayIndex];
            }

            return new MyString(result);
        }
        public static MyString operator -(MyString rowLeft, MyString rowRight)
        {
            char[] temp = rowLeft.ToCharArray();
            int bingo = 0;
            for (int i = 0; i < rowLeft.Count; i++)
            {
                if(rowLeft[i] == rowRight[bingo])
                {
                    bingo++;
                }
                else
                {
                    bingo = 0;
                }
                if (bingo == rowRight.Count)
                {
                    int firstIndex = i - rowRight.Count + 1;
                    int lastIndex = i;
                    for(int j = firstIndex; j <= lastIndex; j++)
                    {
                        temp[j] = '\0';
                    }
                    bingo = 0;
                }
            }
            temp = temp.Where(x => x != '\0').ToArray();
            return new MyString(temp);
        }
        public static bool operator ==(MyString rowLeft, MyString rowRight)
        {
            char[] arrayLeft = rowLeft.ToCharArray();
            char[] arrayRight = rowRight.ToCharArray();
            return Enumerable.SequenceEqual(arrayLeft, arrayRight);
        }
        public static bool operator !=(MyString rowLeft, MyString rowRight)
        {
            char[] arrayLeft = rowLeft.ToCharArray();
            char[] arrayRight = rowRight.ToCharArray();
            return !Enumerable.SequenceEqual(arrayLeft, arrayRight);
        }

        public int Count => ((ICollection)_array).Count;
        public bool IsSynchronized => _array.IsSynchronized;
        public object SyncRoot => _array.SyncRoot;
        public override string ToString()
        {
            return new string(_array);
        }
        public char[] ToCharArray()
        {
            return _array;
        }
        public void CopyTo(Array array, int index)
        {
            _array.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return _array.GetEnumerator();
        }
    }
}
