using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Sum
{
    public Sum()
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
}

