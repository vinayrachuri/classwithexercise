using System;

namespace Exercisewithclass1
{
    public class Sum1
    {
        public void PrintSum1()
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
    }
}
