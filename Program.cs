using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeclaringMethod
{
    class program
    {
        public void OddNumbers()
        {
            Console.WriteLine("the odd numbers of given range are ");
            for (int j = 1; j < 20; j++)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j);
                }
            }

        }

        public void LargestNumbers()
        {
            Console.WriteLine("LargestNumber among three numbers");
            int number1, number2, number3;
            Console.WriteLine("Enter the number num1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number num2");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number num3");
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

        public void SwapNumber()
        {
            Console.WriteLine("Swaping of numbers using third variable");
            int num1, num2;
            Console.WriteLine("Enter the number num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Numbers after swapping");
            Console.WriteLine("num1 " + num1);
            Console.WriteLine("num2 " + num2);
        }

        public void SwapNumber1()
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

        public  void Sum()
        {
            Console.WriteLine("Sum of All the Multiples of 3");
            Console.WriteLine("Enter limit:");
            int limit = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < limit; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("The sum of multiples: " + sum);
        }

        public  void Sum1()
        {
            Console.WriteLine("Sum of All the Multiples of 5");
            Console.WriteLine("Enter limit:");
            int limit = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < limit; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum of multiples: " + sum);
        }

        public void sum2()
        {
            Console.WriteLine("Sum of All the Multiples of 17 which are less than 100");
            int limitNum = 100;
            for (int i = 1; i < limitNum; i++)
            {
                if (i % 17 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void SumOfDigital()
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

        public  static void Main(string[] args)
        {
            //creating object of class Program
            program p = new program();
            string selectAction = "";

            while (selectAction != "0")
            {
                Console.WriteLine("1. OddNumbers");
                Console.WriteLine("2. LargestNumbers");
                Console.WriteLine("3. SwapNumbers");
                Console.WriteLine("4. SwapNumbers1");
                Console.WriteLine("5. Sum");
                Console.WriteLine("6. Sum1");
                Console.WriteLine("7. Sum2");
                Console.WriteLine("8. SumOfDigits");
                Console.WriteLine("0. Exit");
                selectAction = Console.ReadLine();

                switch (selectAction)
                {
                    case "1":
                        p.OddNumbers();
                        break;
                    case "2":
                        p.LargestNumbers();
                        break;
                    case "3":
                        p.SwapNumber();
                        break;
                    case "4":
                        p.SwapNumber1();
                        break;
                    case "5":
                        p.Sum();
                        break;
                    case "6":
                        p.Sum1();
                        break;
                    case "7":
                        p.SumOfDigital();
                        break;
                    case "8":
                        p.SumOfDigital();
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;

                }
                
            }
        }
    }
}

