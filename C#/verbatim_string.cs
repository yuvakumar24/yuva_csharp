using System;
namespace verbatim
{
    public class program
    {
        public static void str()
        {
            //string s1 = "her name is "emma" and she is 18 years old";
           /* In s1, suppose we want to keep emma in double quotes its not possible .so now let use verbatim string @ and keep emma in the "" "".now we get the output as we wished earlier*/
           string s2 = @"her name is ""emma"" and she is 18 years old ";
           Console.WriteLine(s2);
           //inter polaration can be also done, see below example
           string s3 = "yuva";
           string s4 = $@"my name is ""{s3}""";
           System.Console.WriteLine(s4);



        }
    }
}