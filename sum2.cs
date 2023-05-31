using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercisewithclass1
{
    internal class sum2
    {
        public  sum2()
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
