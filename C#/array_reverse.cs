using System;
namespace reverse
{
    public class program
    {
        public static void rev()
        {
            int[] numbers = new int[]
            {
                1,2,3,4,5,6
            } ;  
            numbers.Reverse();
            foreach( int item in numbers)
            {
                System.Console.Write($"{item}");
            }


                 }
    }
}