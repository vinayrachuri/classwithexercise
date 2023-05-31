using System;

namespace Exercisewithclass1
{
    public class SwapNumbers1
    {
        public void PrintSwapNumbers1()
        {
            Console.WriteLine("Swaping of numbers without using third variable");
            int n1, n2;
            Console.WriteLine("Enter the number num1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number num2");
            n2 = Convert.ToInt32(Console.ReadLine());

            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;

            Console.WriteLine("Numbers after swapping");
            Console.WriteLine("num1 " + n1);
            Console.WriteLine("num2 " + n2);


        }
    }
}
