using System;

namespace Exercisewithclass1
{
    public class LargestNumbers
    {
        public void FindLargestNumber()
        {
            Console.WriteLine("Largest number among three numbers");
            int number1, number2, number3;
            Console.WriteLine("Enter the number num1:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number num2:");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number num3:");
            number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("num1 is the largest");
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine("num2 is the largest");
            }
            else
            {
                Console.WriteLine("num3 is the largest");
            }
        }
    }
}
