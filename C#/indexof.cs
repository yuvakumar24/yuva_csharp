using System;
namespace index 
{
    public class program
    {
        public static void of()
        {
            int[] numbers = new int[]
            {
                1,2,3,4,55,6,7,7,8

            };
            System.Console.WriteLine("enter the number you want to search ");
            int search = Convert.ToInt32(Console.ReadLine());

            int position = Array.IndexOf(numbers,search);
            if(position > -1)
               {
                  System.Console.WriteLine($"the number your searching {search} is at position{position} ");

               }
          
            Console.ReadLine();



        }
    }
}