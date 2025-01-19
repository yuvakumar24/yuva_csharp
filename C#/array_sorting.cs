using System;
using System.Globalization;
namespace sort
{
    public class program
    {
        public static void sorting()
        {
            int[] number = new int[]
            {
                2,5,3,1,9,8,7
            };
            Array.Sort(number);
            for(int i=0;i<number.Length;i++)
            {
                Console.Write($"{number[i]}");
                
            }

        }

    }
}