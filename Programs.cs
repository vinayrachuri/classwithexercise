using Exercisewithclass1;
using System;

public class MainClass
{
    public static void Main()
    {
        string selectAction = "";

        while (selectAction != "0")
        {
            Console.WriteLine("1.OddNumbers ");
            Console.WriteLine("2.LargestNumbers");
            Console.WriteLine("3.SwapNumbers");
            Console.WriteLine("4.SwapNumbers1");
            Console.WriteLine("5.Sum ");
            Console.WriteLine("6.Sum 1 ");
            Console.WriteLine("7.Sum 2");
            Console.WriteLine("8.SumOfDigits");
            Console.WriteLine("0 Exit");

            selectAction = Console.ReadLine();

            switch (selectAction)
            {
                case "1":
                    OddNumbers oddNumbers = new OddNumbers();
                    break;
                case "2":
                    LargestNumbers largestNumber = new LargestNumbers();
                    break;
                case "3":
                    SwapNumbers swapNumber = new SwapNumbers();
                    break;
                case "4":
                    SwapNumbers1 swapNumber1 = new SwapNumbers1();
                    break;
                case "5":
                    Sum sum = new Sum();
                    break;
                case "6":
                    Sum1 sum1 = new Sum1();
                    break;
                case "7":
                    sum2 sum2 = new sum2();
                    break;
                case "8":
                    SumOfDigits sumOfDigits = new SumOfDigits();
                    break;
            }
        }
    }
}
