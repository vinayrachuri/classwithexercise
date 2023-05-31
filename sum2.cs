using System;

namespace Exercisewithclass1
{
    public class Sum2
    {
        public void PrintSum2()
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
    }
}
