﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public static class Problems
    {
        private static void Problem1()
        {
            Console.WriteLine("Problem: If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.");

            int sum = 0;

            for (int i = 3; i < 1000; i++)
            {

                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Answer: {sum}");
        }

        private static void Problem2()
        {
            Console.WriteLine("Problem: By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.");
        }
    }
}
