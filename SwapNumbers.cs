using System;

namespace Exercisewithclass1
{
    public class SwapNumbers
    {
        public void PrintSwapNumbers()
        {
            Console.WriteLine("Swapping of numbers using a third variable");
            int num1, num2;
            Console.WriteLine("Enter the number num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("Numbers after swapping:");
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);
        }
    }
}
