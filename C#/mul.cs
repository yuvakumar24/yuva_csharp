using System;
namespace mul
{
    public class program
    {
        public static void mult()
        {
            Console.WriteLine("enter the number1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int actual_answer = num1 * num2;
            Console.WriteLine("enter the user answer");
            int user_answer = Convert.ToInt32(Console.ReadLine());
            if(actual_answer==user_answer)
            {
                System.Console.WriteLine("well done");
            }
            else
            System.Console.WriteLine("try again");



        }


    }
}