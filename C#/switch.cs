using System;
namespace switc
{
    public class program
    {
        public static void cases() 
        {
            Console.WriteLine("enter the day of the week");
            int day = Convert.ToInt32(Console.ReadLine());
            int value;
            int.TryParse("naveen",out value);

            switch(day)
            {
                case 1:System.Console.WriteLine("monday");
                break;
                case 2:System.Console.WriteLine("tuesday");
                break;
                case 3: System.Console.WriteLine("wednesday");
                break;
                case 4:System.Console.WriteLine("thursday");
                break;
                case 5:System.Console.WriteLine("friday");
                break;
                case 6:System.Console.WriteLine("saturday");
                break;
                case 7:System.Console.WriteLine("sunday");
                break;
                default: System.Console.WriteLine("inavlid, enter a valid value between 11 and 7");
                break;


            }

        }


    }
}