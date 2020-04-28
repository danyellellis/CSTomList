using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T>
    {
        // member variables (HAS A)
        private T[] items;
        public readonly int countProperty;
        public int capacityProperty;



        // constructor (SPAWNER)
        public CustomList()
        {
            countProperty = 0;
            capacityProperty = 4;
            items = new T[capacityProperty];
            
        }

        // member methods (CAN DO)
        public void Add(T item)
        {
            //Write logic to make the Add tests pass!
        }
    }
}
