using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
namespace oddoreven
{
    public class program
    {
        public static void checking()
        {
           var num1=20;
           var num2=10;
           var remainder=num1%num2;
           System.Console.WriteLine(remainder);

           num1=21;
           remainder=num1%num2;
           System.Console.WriteLine(remainder);




        }
    }
}