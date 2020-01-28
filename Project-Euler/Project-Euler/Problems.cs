using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

        public static string Problem8()
        {
            Console.WriteLine("\n\t8) Find the thirteenth adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?");

            string bigInteger = "73167176531330624919225119674426574742355349194934" +
                                "96983520312774506326239578318016984801869478851843" +
                                "85861560789112949495459501737958331952853208805511" +
                                "12540698747158523863050715693290963295227443043557" +
                                "66896648950445244523161731856403098711121722383113" +
                                "62229893423380308135336276614282806444486645238749" +
                                "30358907296290491560440772390713810515859307960866" +
                                "70172427121883998797908792274921901699720888093776" +
                                "65727333001053367881220235421809751254540594752243" +
                                "52584907711670556013604839586446706324415722155397" +
                                "53697817977846174064955149290862569321978468622482" +
                                "83972241375657056057490261407972968652414535100474" +
                                "82166370484403199890008895243450658541227588666881" +
                                "16427171479924442928230863465674813919123162824586" +
                                "17866458359124566529476545682848912883142607690042" +
                                "24219022671055626321111109370544217506941658960408" +
                                "07198403850962455444362981230987879927244284909188" +
                                "84580156166097919133875499200524063689912560717606" +
                                "05886116467109405077541002256983155200055935729725" +
                                "71636269561882670428252483600823257530420752963450";

            BigInteger biggestProduct = 0;
            
            for (int i = 0; i < bigInteger.Length - 13; i++)
            {
                BigInteger tempProduct = 1;

                for (int j = 0; j <= 12; j++)
                {
                    // Each character needs to be converted into a string and then an int in order to avoid executing the operation with the unicode value of each char.
                    tempProduct *= Convert.ToInt32(bigInteger[i + j].ToString());
                }

                if (tempProduct > biggestProduct)
                {
                    biggestProduct = tempProduct;
                }
            }

            return biggestProduct.ToString();
        }

        public static string Problem18()
        {
            Console.WriteLine("\n\t18) Find the maximum total from top to bottom of the given triangle.");

            // Each list is a row of the triangle.
            List<List<int>> triangle = new List<List<int>>() { 
                new List<int>() {3}, 
                new List<int>() {95,64}, 
                new List<int>() {17, 47, 82}, 
                new List<int>() {18, 35, 87, 10}, 
                new List<int>() {20, 04, 82, 47, 65},
                new List<int>() {19, 01, 23, 75, 03, 34}, 
                new List<int>() {88, 02, 77, 73, 07, 63, 67}, 
                new List<int>() {99, 65, 04, 28, 06, 16, 70, 92}, 
                new List<int>() {41, 41, 26, 56, 83, 40, 80, 70, 33}, 
                new List<int>() {41, 48, 72, 33, 47, 32, 37, 16, 94, 29}, 
                new List<int>() {53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14}, 
                new List<int>() {70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57},
                new List<int>() {91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48}, 
                new List<int>() {63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31}, 
                new List<int>() {04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23}};

            return "answer";
        }
    }
}
