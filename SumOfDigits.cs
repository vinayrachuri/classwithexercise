using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercisewithclass1
{
    internal class SumOfDigits
    {
        public  SumOfDigits()
        {
            Console.WriteLine("Find Sum of Digits of a Number");
            Console.WriteLine("Enter a Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int sumOfDigits = 0;
            int tempNum = number;

            while (tempNum != 0)
            {
                int digit = tempNum % 10;
                sumOfDigits += digit;
                tempNum /= 10;
            }

            Console.WriteLine("Sum of the digits: " + sumOfDigits);

        }
    }
}
