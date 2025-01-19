using System;
namespace stringcomversion
{
    public class program
    {
        public static void convert()
        {
            string textage = "32";
            int age=Convert.ToInt32(textage);
            Console.WriteLine(age);

            string textbignumber="900000";
            long bignumber=Convert.ToInt64(textbignumber);
            Console.WriteLine(bignumber);

            string textnegative = "-55.2";
            double negative = Convert.ToDouble(textnegative);
            Console.WriteLine(negative);
            
            string textprecision =  "5.000001";
            float precision =Convert.ToSingle(textprecision);
            Console.WriteLine(precision);


            string textmoney = "14.99";
            decimal money = Convert.ToDecimal(textmoney);
            Console.WriteLine(money);



    }
}
}
