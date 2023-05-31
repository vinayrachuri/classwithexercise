using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class SwapNumbers
    {
        public  SwapNumbers()
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

    }

