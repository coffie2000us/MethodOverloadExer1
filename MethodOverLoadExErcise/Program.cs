using System;

namespace MethodOverLoadExErcise
{
    class Program
    {
        
        //Create a method named Add, that accepts two integers and
        //returns the sum of those two integers
        static void Main(string[] args)
        {
            Console.WriteLine(3);
            Add(2, 3);
            Add(2.4m, 5.1m);
            Add(1, 1, false);
        }

        public static int Add(int a, int b)
        {

            return a + b;
            
        }
        public static decimal Add(decimal a, decimal b)
        {

            return a + b;
        }

        public static string Add(int c, int d, bool isFishTasty)
        {
            var sum = c + d;
            if (isFishTasty == true && sum > 1)
            {
                return $"(sum) dollars";
            }
            else if (isFishTasty == true && sum == 1)
            {
                return $"(sum) dollar";
            }
            else if(isFishTasty == true && sum < 1)
            {
                return $"(sum) dollars";
            }  
            else
            {
                return sum.ToString();
            }
        
        }

    }   
}
