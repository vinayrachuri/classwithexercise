using Exercisewithclass1;
using System;

class Program
{
    public static void Main()
    {
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
            Program p = new Program();

            switch (selectAction)
            {
                case "1":
                    OddNumbers oddNumbers = new OddNumbers();
                    oddNumbers.PrintOddNumbers();
                    break;
                case "2":
                    LargestNumbers largestNumbers = new LargestNumbers();
                    largestNumbers.FindLargestNumber();
                    break;
                case "3":
                    SwapNumbers swapNumbers = new SwapNumbers();
                    swapNumbers.PrintSwapNumbers();
                    break;

                case "4":
                    SwapNumbers1 swapNumbers1 = new SwapNumbers1();
                    swapNumbers1.PrintSwapNumbers1();
                    break;
                case "5":
                    Sum sum = new Sum();
                    Sum.PrintSum();
                    break;
                case "6":
                    Sum1 sum1 = new Sum1();
                    sum1.PrintSum1();
                    break;
                case "7":
                    Sum2 sum2 = new Sum2();
                    sum2.PrintSum2();
                    break;
                case "8":
                    SumOfDigits sumofdigits = new SumOfDigits();
                    sumofdigits.PrintSumOfDigits();
                    break;
            }
        }
    }
}


