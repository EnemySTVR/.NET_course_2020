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

        public MyString(char[] arr)
        {
            _array = arr;
        }
        public MyString(string str)
        {
            _array = str.ToCharArray();
        }

        public static MyString operator +(MyString s1, MyString s2)
        {
            int new_count = s1.Count + s2.Count;
            char[] result = new char[new_count];

            for (int i = 0; i < s1.Count; i++)
            {
                result[i] = s1[i];
            }

            int added_array_index = 0;
            for (int i = s1.Count; i < new_count; i++, added_array_index++)
            {
                result[i] = s2[added_array_index];
            }

            return new MyString(result);
        }
        public static MyString operator -(MyString s1, MyString s2)
        {
            char[] temp = s1.ToCharArray();
            int bingo = 0;

            for (int i = 0; i < s1.Count; i++)
            {
                if(s1[i] == s2[bingo])
                {
                    bingo++;
                }
                else
                {
                    bingo = 0;
                }
                if (bingo == s2.Count)
                {
                    int first_index = i - s2.Count + 1;
                    int last_index = i;
                    for(int j = first_index; j <= last_index; j++)
                    {
                        temp[j] = '\0';
                    }

                    bingo = 0;
                }
            }

            temp = temp.Where(x => x != '\0').ToArray();

            return new MyString(temp);
        }
        public static bool operator ==(MyString s1, MyString s2)
        {
            char[] array1 = s1.ToCharArray();
            char[] array2 = s2.ToCharArray();
            return Enumerable.SequenceEqual(array1, array2);
        }
        public static bool operator !=(MyString s1, MyString s2)
        {
            char[] array1 = s1.ToCharArray();
            char[] array2 = s2.ToCharArray();
            return !Enumerable.SequenceEqual(array1, array2);
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
