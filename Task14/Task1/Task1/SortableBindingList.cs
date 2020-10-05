using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Task1
{
    public class SelfSortingBindingList<T> : BindingList<T>
    {
        public void SortItemsByProperty(string propertyName)
        {
            if (Count <= 1)
            {
                return;
            }

            Type itemType = this[0].GetType();
            PropertyInfo targetProperty = itemType.GetProperty(propertyName);

            IList propertiesArray = Array.CreateInstance(targetProperty.PropertyType, Count);
            for (int i = 0; i < Count; i++)
            {
                propertiesArray[i] = targetProperty.GetValue(this[i]);
            }

            Array.Sort(propertiesArray as Array);

            IList tempArray = Array.CreateInstance(itemType, Count);
            for (int i = 0; i < Count; i++)
            {
                foreach (T element in this)
                {
                    var valuePropertyOfCurrentElement = targetProperty.GetValue(element);

                    if (propertiesArray[i].Equals(valuePropertyOfCurrentElement) && !tempArray.Contains(element))
                    {
                        tempArray[i] = element;
                    }
                }
            }

            Clear();

            foreach (var item in tempArray)
            {
                Add((T)item);
            }
        }

        private bool isContains(T item, IList list)
        {
            var comparer = new ItemsComparer();
            int compareResult;
            foreach (T element in list)
            {
                compareResult = comparer.Compare(item, element);
                if (compareResult != 0)
                {
                    return false;
                }
                
            }
            return true;
        }
        private class ItemsComparer : IComparer<T>
        {
            public int Compare(T x, T y)
            {
                int xHashCode = x.GetHashCode();
                int yHashCode = y.GetHashCode();
                return xHashCode.CompareTo(yHashCode);
            }
        }
    }
}
