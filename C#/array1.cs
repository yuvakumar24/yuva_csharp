using System;
namespace arrr
{
    public class program
    {
        public static void arrr1()
        {
            // creating an array as below
            int[] numbers = new int[3];

            // below is declaring  the values in array which is created above without using loop
           /* System.Console.WriteLine("enter number 1:");
            numbers[0] = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("enter number 2:");
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("enter number 3:");
            numbers[2] = Convert.ToInt32(Console.ReadLine());*/

            // now let us create the loop for declaring the values in array
            for( int i =0;i<numbers.Length;i++)

            {
                System.Console.WriteLine("enter the number :");
                numbers[i]=Convert.ToInt32(Console.ReadLine());

            }



            for( int i =0;i<numbers.Length;i++)

            {
                System.Console.Write($"{numbers[i]}");
            }


        }

    }
}