using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class OddNumbers
    {
        public  OddNumbers()
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
    }
