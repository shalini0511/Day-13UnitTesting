using System;

namespace FindMaxValue
{



    public class Program
    {


        public string FindMaximumString(string first, string second, string third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("All three having same number");
                return default;
            }
        }



        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Maximum value is : " + obj.FindMaximumString("Apple", "Banana", "Peach"));

            Console.ReadLine();
        }


    }

    
        
            
        
    
}
