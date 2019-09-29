using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class MathyHelper
    {
        public static bool IsPrime(long number)
        {
            long squareRoot = (long)Math.Sqrt(number);

            for (int i = 2; i <= squareRoot; i++)
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
            for (int i = 0, j = characters.Length - 1; i < j; i++, j--)
            {
                if (characters[i] != characters[j])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsDivisibleFrom1To20(int number)
        {
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
