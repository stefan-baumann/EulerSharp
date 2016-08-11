using System;

namespace EulerSharp.Problem6.Optimized
{
    /* Problem Description:
     * The sum of the squares of the first ten natural numbers is 1^2 + 2^2 + ... + 10^2 = 385
     * The square of the sum of the first ten natural numbers is (1 + 2 + ... + 10)^2 = 55^2 = 3025
     * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
     * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
     * 
     * Solution Notes:
     * - The sum of the squares of the first x natural numbers is x * (x + 1) * (2 * x + 1) / 6
     * - The square of the sum of the first x natural numbers (x * (x + 1) / 2)^2 or x^2 * (x + 1)^2 / 4
     */

    public static class Program
    {
        public static void Main(string[] args)
        {
            int squareSum = 100 * (100 + 1) * (2 * 100 + 1) / 6; //The sum of the first 100 natural numbers squared individually

            //Calculate the sum of the first 100 natural numbers, squared
            int sumSquared = 100 * 100 * (100 + 1) * (100 + 1) / 4;

            //Calculate the difference (as the difference is always positive or 0, we use the Math.Abs function to get the absolute value)
            int difference = Math.Abs(squareSum - sumSquared);

            //Write the result to the console
            Console.WriteLine("The difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is " + difference);

            //Wait for a keypress before terminating the program (so that the user can read the output)
            Console.ReadKey(true);
        }
    }
}
