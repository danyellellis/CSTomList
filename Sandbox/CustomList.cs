using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T> : IEnumerable
    {
        // member variables (HAS A)
        private T[] items;
        public  int countProperty;
        public int capacityProperty;



        // constructor (SPAWNER)
        public T this[int index]
        {
            get
            {
                if (index < countProperty && index >= 0)
                {
                    return items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
            set
            {
                items[index] = value;
            }
        }

        public int Count
        {
            get
            {   
               return countProperty;   
            }
        }

        public int Capacity
        {
            get
            {
                return capacityProperty;
            }
        }
        public CustomList()
        {
            countProperty = 0;
            capacityProperty = 4;
            items = new T[capacityProperty];
            
        }

        // member methods (CAN DO)
        public void Add(T item)
        {
            if(countProperty == capacityProperty )
            {
                //we want capacity to double
                capacityProperty = capacityProperty * 2;
                T[] tempArray = new T[capacityProperty];
                for (int i = 0; i < countProperty; i++)
                {
                      tempArray[i] = items[i];
                }
                items = tempArray;
            }
            
            items[countProperty] = item;
            countProperty++;
            //Write logic to make the Add tests pass!
        }

        public void Remove(T Item)
        {
            
            T[] tempArray = new T[capacityProperty];
            for (int i = countProperty; i < tempArray.Length; i++)
            {
                if (i >= tempArray.Length - 1 )
                {
                    items[i] = tempArray[i];
                }
            }
             items = tempArray;
            countProperty++;
            //Step through list with for loop
            //compare each item to the item being removed
            //if you find the item being removed in the list, what will you do?
        }


        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < countProperty; i++)
            {
                yield return items[i];
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }




    }
}
