using System;

public class MainClass
{
    public static void Main()
    {
        OddNumbers();
        LargestNumber();
        SwapNumbers();
        SwapNumbers1();
        sum();
        Sum1();
        sum2();
        SumOfDigits();


    }

    public static void OddNumbers()
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
    
    public static void LargestNumber()
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

    public static void SwapNumbers()
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

    public static void SwapNumbers1()
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
    public static void sum()
    {
                    Console.WriteLine("Sum of All the Multiples of 3");
                    Console.WriteLine("Enter limit:");
                    int limit = Convert.ToInt32(Console.ReadLine());
                    int sum = 0;

                    for (int i = 0; i<limit; i++)
                    {
                        if (i % 3 == 0)
                        {
                            sum = sum + i;
                        }
                    }
                    Console.WriteLine("The sum of multiples: " + sum);

    }
    public static void Sum1()
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
     public static void sum2()
    {
         Console.WriteLine("Sum of All the Multiples of 17 which are less than 100");
        int limitNum = 100;
                 for (int i = 1; i<limitNum; i++)
                 {
                        if (i % 17 == 0)
                        {
                            Console.WriteLine(i);
                        }
                 }
    }

    public static void SumOfDigits()
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
