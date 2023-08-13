using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace N22_HT_Task1
{
    internal class CustomList<T>
    {
        private readonly int _capasity = 0;
        public  T[] items;
        public CustomList()
        {
            items = new T[_capasity];
        }
        public CustomList(int size)
        {
            if(size < 0)
            {
                throw new ArgumentOutOfRangeException("size");
            }
            else if(size == 0)
            {
                items = new T[_capasity];
            }
            else
            {
                items = new T[size];
            }
        }
        public void Add( T item)
        {

            CheckingSize();
            items[items.Length - 1] = item;
        }

        public void CheckingSize()
        {
          Array.Resize(ref items, items.Length + 1); 
        }

        public void AddRange(params T[] items)
        {
            foreach(T item in items)
            {
                Add(item);
            }
        }

        public bool Contains(T item)
        {
            foreach(T itemA in items)
            {
                if (itemA.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        public void CopyTo(T[] array)
        {
            if(array.Length < items.Length)
            {
                throw new Exception("Xato");
            }
            
            for(var item  = 0; item < items.Length; item++)
            {
                array[item] = items[item];
            }
            
        }

        public int IndexOf(T item)
        {
            for(int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Insert(int index, T item)
        {
           
           

            T[] newArray = new T[items.Length + 1];
           

            for (int i = 0; i < index; i++)
                newArray[i] = items[i];
            newArray[index] = item;
           for(var indx = index + 1; indx < items.Length; indx++)
            {
                newArray[indx] = items[indx - 1];
            }

            items = newArray;
        }

        public void InsertRange(int index, params T[] items)
        {
            foreach(var item in items)
            {
                Insert(index, item);
                index++;
            }

        }

        public bool Remove(T item)
        {
           var newArray = new T[items.Length - 1];
            bool isFinde = true;
            var indx = 0;
            for(var i =  0; i < items.Length; i++)
            {
                if (items[i].Equals(item) && isFinde)
                {
                    isFinde = false;
                    
                }
                else
                {
                    newArray[indx] = items[i];
                    indx++;
                }
            }
            if (isFinde)
                return false;
            else
            {
                items = newArray;
                return true;
            }

            /*if (isFinde)
            {
                return false;
            }
            else
            {
                items = newArray;
                return true;
            }*/
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= items.Length)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            var newArray = new T[items.Length - 1];
            bool isFound = false;
            var newIndex = 0;

            for (var i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    isFound = true;
                    continue;
                }

                newArray[newIndex] = items[i];
                newIndex++;
            }

            if (!isFound)
                return false;
            else
            {
                items = newArray;
                return true;
            }
        }
        public T[] ToArray()
        {
           return items;
        }
        public override string ToString()
        {
            var returnn = "";
            foreach(var item in items)
            {
                returnn = returnn + Convert.ToString(item) + "";
            }
            return returnn;
        }


      
    }
}
