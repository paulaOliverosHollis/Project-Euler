using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public static class Problems
    {
        public static string Problem1()
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

            return sum.ToString();
        }

        public static string Problem2()
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

            return sum.ToString();
        }

        public static string Problem3()
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
                while (numberToBeDivided % diviser == 0)
                {
                    numberToBeDivided /= diviser;
                }

                if (MathyHelper.IsPrime(numberToBeDivided))
                {
                    break;
                }

                // If the numberToBeDivided is not divisable by the current diviser anymore but it is not a prime number, we move onto the next diviser.
                diviser++;
            }

            return numberToBeDivided.ToString();
        }

        public static string Problem4()
        {
            Console.WriteLine("\n\t4) Find the largest palindrome made from the product of two 3 digit numbers.");

            int currentProduct;
            int greatestProduct = 0;

            // These loops iterate through every single possible combination of 3-digit numbers and multiplays them. 
            for (int i = 999; i > 99; i--)
            {
                // Second loop always starts with whatever the value of i is since we have already calculated all the multiplication combinations of the previous i. 
                for (int j = i; j > 99; j--)
                {
                    currentProduct = i * j;

                    if (MathyHelper.IsPalendromic(currentProduct.ToString()) && currentProduct > greatestProduct)
                    {
                        greatestProduct = currentProduct;
                    }
                }
            }

            return greatestProduct.ToString();
        }

        public static string Problem5()
        {
            Console.WriteLine("\n\t5) What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?");

            for (int i = 20; i < int.MaxValue; i += 20)
            {
                if (MathyHelper.IsDivisibleFrom1To20(i))
                {
                    return i.ToString();
                }
            }

            return "Unable to find the answer.";
        }

        public static string Problem6()
        {
            Console.WriteLine("\n\t6) Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.");

            int sum = 0;
            int sumOfSquares = 0;

            for (int i = 1; i < 101; i++)
            {
                sum += i;
                sumOfSquares += i * i;
            }

            int squareOfSum = sum * sum;

            return (squareOfSum - sumOfSquares).ToString();
        }

        public static string Problem7()
        {
            Console.WriteLine("\n\t7) What is the 10,001st prime number?");

            long number = 3;
            int counter = 1; // 2 is already counted.

            while (counter != 10001)
            {
                if (MathyHelper.IsPrime(number))
                {
                    counter++;
                }

                number += 2;
            }

            return (number - 2).ToString();
        }
    }
}
