using System;
namespace clearing
{
    public class program
    {
        public static void clear()
        {
            int[] numbers = new int[]
            {1,2,3,4,5,6,5

            };
            Array.Clear(numbers);
            foreach(var item in numbers)
            {
                System.Console.WriteLine($"{item}");
            }

    }
}
}
