using System;
namespace strin
{
    public class program
    {
       public static void empty()
       {
        System.Console.WriteLine("enter your name:");
        string name = Console.ReadLine();
        if(name != string.Empty)
        {
            System.Console.WriteLine($"your name is {name}");

        }
        else 
        {
            System.Console.WriteLine("string is empty");
        }


       }
       
       
       
       
       
           }
}