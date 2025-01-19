using System;
namespace conditionals
{
    public class program
    {
        public static void age()
        {
            Console.WriteLine("enter you age:");
            int age = Convert.ToInt32(Console.ReadLine());


            if(age<=0 || age>=125)
            {
                Console.WriteLine("invalid age ");
            }
            else
            {
                if(age>=18)
                {
                    Console.WriteLine("your elgible to vote");
                }
                else if(age>=21 && age<=70)
                {
                    Console.WriteLine("your adult now");
                }
                
            }

        }

    }
}