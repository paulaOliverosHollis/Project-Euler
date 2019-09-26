using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public static class Problems
    {
        public static void Problem1()
        {
            Console.WriteLine("\n\t1) If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.");

            int sum = 0;

            for (int i = 3; i < 1000; i++)
            {

                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"\n\tSolution: {sum}");
        }

        public static void Problem2()
        {
            Console.WriteLine("\n\t2) By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.");

            int firstNum = 1;
            int secondNum = 2;
            int thirdNum;
            int sum = 2;

            while (true)
            {
                thirdNum = firstNum + secondNum;

                if (thirdNum > 4000000)
                {
                    break;
                }
                else if (thirdNum % 2 == 0)
                {
                    sum += thirdNum;
                }

                firstNum = secondNum;
                secondNum = thirdNum;
            }

            Console.WriteLine($"\n\tSolution: {sum}");
        }


        public static void Problem3()
        {
            Console.WriteLine("\n\t3) What is the largest prime factor of the number 600851475143 ?");

            int smallestPrimeNumber = 2;
            long biggestPrimeNumber = 600851475143;

            while (true)
            {
                while (IsItDivisible(smallestPrimeNumber, biggestPrimeNumber))
                {
                    biggestPrimeNumber /= smallestPrimeNumber;
                }
                if (IsItPrime(biggestPrimeNumber))
                {
                    break;
                }
                else
                {
                    smallestPrimeNumber++;
                }
            }

            Console.WriteLine($"\n\tSolution: {biggestPrimeNumber}");
        }

        public static void Problem4()
        {
            Console.WriteLine("\n\t1)Find the largest palindrome made from the product of two 3 digit numbers.");

            int greatestSum = 0;
            int currentNumber = 100;            

            while(currentNumber < 1000)
            {
                int currentSum = currentNumber + ReverseOrder(currentNumber);
            }
        }

        //Helper method.
        private static bool IsItDivisible(int smallestPrimeNumber, long biggestPrimeNumber)
        {
            return biggestPrimeNumber % smallestPrimeNumber == 0;
        }

        //Helper method.
        private static bool IsItPrime(long biggestPrimeNumber)
        {
            double squareRoot = Math.Sqrt(biggestPrimeNumber);


            for (int i = 2; i < squareRoot; i++)
            {
                if (IsItDivisible(i, biggestPrimeNumber))
                {
                    return false;
                }
            }

            return true;
        }

        //Helper method.
        private static int ReverseOrder(int number)
        {
            string currentNumber = number.ToString();
            string reversedNumber = "";
            int currentNumberLength = currentNumber.Length;

            for(int i = currentNumberLength - 1; i >= 0; i--)
            {
                reversedNumber += currentNumber[i];
            }

            return int.Parse(reversedNumber);
        }

        //Helper method.       
    }
}
