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
                int[] tempArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
                for (int i = 0; i < countProperty; i++)
                {

                }

              
                //create a new array with size 'capacityPropety', call it tempArray
                //items [x, x, x, x]
                //tempArray [_, _, _, _, _, _, _, _]

                //transfer the first things from 'items' into tempArray


            }


            items[countProperty] = item;
            countProperty++;
            //Write logic to make the Add tests pass!
        }


        public void Remove(T Item)
        {
            for (int i = 0; i < countProperty; i++)
            {

            }

        }


        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < countProperty; i++)
            {
                yield return items[i];
            }
        }



        
    }
}
