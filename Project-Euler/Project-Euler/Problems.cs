﻿using System;
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
            Console.WriteLine("\n\t3) What is the largest prime factor of the number 600,851,475,143?");

            int diviser = 2;

            // This number will be divided several times until it cannot be divided by numbers other than 1 and itself, 
            // which means we have found the biggest prime factor of the initial value.
            long numberToBeDivided = 600851475143;

            int initialValueSqrt = (int)Math.Sqrt(numberToBeDivided);// A prime factor of a number cannot be larger that the number's square root.

            for (int i = 0; i < initialValueSqrt; i++)
            {
                // The numberToBeDivided is divided by the same diviser for as long as the number is divisible by that specific diviser.
                while (IsItDivisible(diviser, numberToBeDivided))
                {
                    numberToBeDivided /= diviser;
                }

                if (IsItPrime(numberToBeDivided))
                {
                    break;
                }

                // If the numberToBeDivided is not divisable by the current diviser anymore but it is not a prime number, we move onto the next diviser.
                diviser++;
            }

            Console.WriteLine($"\n\tSolution: {numberToBeDivided}");
        }

        private static bool IsItDivisible(int diviser, long numberToBeDivided)
        {
            return numberToBeDivided % diviser == 0;
        }

        private static bool IsItPrime(long number)
        {
            int squareRoot = (int)Math.Sqrt(number);


            for (int i = 2; i < squareRoot; i++)
            {
                if (IsItDivisible(i, number))
                {
                    return false;
                }
            }

            return true;
        }

        public static void Problem4()
        {
            Console.WriteLine("\n\t1)Find the largest palindrome made from the product of two 3 digit numbers.");

            int biggestSum = 0;

        }

        //Helper method.
        //private static int ReverseOrder(int number)
        //{
        //    string currentNumber = number.ToString();
        //    string reversedNumber = "";
        //    int currentNumberLength = currentNumber.Length;

        //    for (int i = currentNumberLength - 1; i >= 0; i--)
        //    {
        //        reversedNumber += currentNumber[i];
        //    }

        //    return int.Parse(reversedNumber);
        //}
    }
}
