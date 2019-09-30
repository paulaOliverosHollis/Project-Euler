using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class MathyHelper
    {
        public static bool IsPrime(long number)
        {
            long squareRoot = (long)Math.Sqrt(number);

            if (number % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsPalendromic(string characters)
        {
            if (string.IsNullOrEmpty(characters))
            {
                return false;
            }

            // Comparing each character by starting from both ends of the string simultaneously.
            for (int frontPointer = 0, backPointer = characters.Length - 1; frontPointer < backPointer; frontPointer++, backPointer--)
            {
                if (characters[frontPointer] != characters[backPointer])
                {
                    return false;
                }
            }

            return true;
        }

        // For  performance purposes, this method does not accept more generic parameters such as a range of numbers to check. 
        public static bool IsDivisibleFrom1To20(int number)
        {
            // We do not check divisivility by any number under 11 since we are already checking 
            // divisibility by 12, 14, 15, 16, 18 and 20 which will provide us with the answer we need.
            for (int i = 11; i < 21; i++)
            {
                if (number % i != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
