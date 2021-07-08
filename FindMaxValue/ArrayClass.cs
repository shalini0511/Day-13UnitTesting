using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxValue
{
    class ArrayClass<T>
    {
         
        //To print the int array
        private T[] inputArray;
        public ArrayClass(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void ToPrint()
        {
            foreach (var ele in inputArray)
            {
                Console.Write(ele + " ");
            }
        }
    }
}
