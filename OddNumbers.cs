using System;

namespace Exercisewithclass1
{
    public class OddNumbers
    {
        public void PrintOddNumbers()
        {
            Console.WriteLine("Odd numbers of given range:");
            for (int j = 1; j < 20; j++)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
