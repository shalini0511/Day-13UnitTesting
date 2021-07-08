using System;

namespace FindMaxValue
{



     class Program
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics and Unit testing Problem!!!");
            Console.WriteLine("****GENERICS CLASS AND METHODS USING SORTING****");
            Console.WriteLine("--------Integer Array------------");
            int[] arrayIntList = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            SortingClass<int> obj1 = new SortingClass<int>(arrayIntList);
            int maxValue1 = obj1.MaximumValueFunction(arrayIntList);
            Console.WriteLine("Max value= {0} ", maxValue1);

            Console.WriteLine("--------Float Array--------");

            float[] arrayFloatList = { 2.2f, 4.3f, 5.4f, 6.5f };
            SortingClass<float> obj2 = new SortingClass<float>(arrayFloatList);
            float maxValue2 = obj2.MaximumValueFunction(arrayFloatList);
            Console.WriteLine("Max value= {0} ", maxValue2);

            Console.WriteLine("--------String Array--------");

            string[] arrayStringList = { "Apple", "Banana", "Peach", "Kiwi" };
            SortingClass<string> obj3 = new SortingClass<string>(arrayStringList);
            string maxValue3 = obj3.MaximumValueFunction(arrayStringList);
            Console.WriteLine("Max value= {0} ", maxValue3);
            Console.ReadLine();
        }



    }
    }
}
