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

            int currentProduct;
            int greatestProduct = 0;

            // These loops iterate through every single possible combination of 3-digit numbers and multiplays them. 
            for (int i = 999; i > 99; i--)
            {
                // Second loop always starts with whatever the value of i is since we have already calculated all the multiplication combinations of the previous i. 
                for (int j = i; j > 99; j--)
                {
                    currentProduct = i * j;

                    if (IsPalendromic(currentProduct.ToString()) && currentProduct > greatestProduct)
                    {
                        greatestProduct = currentProduct;
                    }
                }
            }

            Console.WriteLine($"\n\tSolution: {greatestProduct}");
        }

        private static bool IsPalendromic(string characters)
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

        public static void Problem5()
        {
            Console.WriteLine("\n\t5)What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?");

            int evenlyDivisibleNumber = 0;

            for(int i = 20; i < int.MaxValue; i += 20)
            {
                if(IsDivisibleFrom1To20(i))
                {
                    evenlyDivisibleNumber = i;
                    break;
                }
            }

            Console.WriteLine($"\n\tSolution: {evenlyDivisibleNumber}");
        }

        private static bool IsDivisibleFrom1To20(int number)
        {
            for(int i = 1; i < 21; i++)
            {
                if(number % i != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
