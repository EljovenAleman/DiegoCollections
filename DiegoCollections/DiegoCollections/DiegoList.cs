using System;
using System.Collections.Generic;

namespace DiegoCollections
{
    public class DiegoList<T>
    {        
        private T[] myList = new T[0];

        public T this[int index]
        {
            get
            {
                return myList[index];
            }

            set
            {
                myList[index] = value;
            }
        }

        public void Add(T addThis)
        {            
            T[] newArray = new T[myList.Length+1];

            for (int i = 0; i < myList.Length; i++)
            {
                newArray[i] = myList[i];
            }

            newArray[myList.Length] = addThis;

            myList = newArray;
        }

        public int Count
        {
            get
            {
                return myList.Length;
            }
            
        }

        public bool Remove(T removeThis)
        {
            T aux = default(T);
            int itemPosition = 0;


            foreach (var item in myList)
            {
                if (EqualityComparer<T>.Default.Equals(item, removeThis))
                {
                    aux = item;
                    break;
                }
                itemPosition++;
            }

            if (EqualityComparer<T>.Default.Equals(aux, default(T)) == false)
            {
                T[] newArray = new T[myList.Length - 1];

                for (int i = 0; i < itemPosition; i++)
                {
                    newArray[i] = myList[i];
                }
                for (int i = itemPosition + 1; i < myList.Length; i++)
                {
                    newArray[i - 1] = myList[i];
                }
                myList = newArray;
                
                return true;
            }
            return false;

        }

        public void Clear()
        {
            T[] newArray = new T[0];
            myList = newArray;            
        }

        public bool Contains(T checkForThis)
        {
            foreach (var item in myList)
            {
                if (EqualityComparer<T>.Default.Equals(item, checkForThis))
                {
                    return true;                    
                }
                
            }

            return false;
        }

        public int CountHowMany(T searchThis)
        {
            int itemsFound = 0;

            foreach (var item in myList)
            {
                if (EqualityComparer<T>.Default.Equals(item, searchThis))
                {
                    itemsFound++;
                }

            }

            return itemsFound;
        }

        public T GetValue(int index)
        {
            return myList[index];
        }
    }
}
