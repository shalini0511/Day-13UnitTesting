using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxValue
{
    class SortingClass<T> where T : IComparable
    {
        public T[] arrayList;
        private string[] arrString;
        private float[] arrFloat;

        public SortingClass(T[] arrayList)
        {
            this.arrayList = arrayList;
        }

        public SortingClass(string[] arrString)
        {
            this.arrString = arrString;
        }

        public SortingClass(float[] arrFloat)
        {
            this.arrFloat = arrFloat;
        }

        public T[] Sort(T[] arrayList)
        {
            Array.Sort(arrayList);
            return arrayList;
        }
        public T MaximumValueFunction(T[] arrayList)
        {
            var sortarrayval = Sort(arrayList);
            return sortarrayval[arrayList.Length - 1];
        }
        public T MaxMethod()
        {
            T maxValue = this.MaximumValueFunction(arrayList);
            return maxValue;
        }
    }
}
