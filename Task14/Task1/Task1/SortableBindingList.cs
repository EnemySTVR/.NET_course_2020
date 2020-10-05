using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;

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
                    if (propertiesArray[i].Equals(targetProperty.GetValue(element))
                        && !tempArray.Contains(element))
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
    }
}
