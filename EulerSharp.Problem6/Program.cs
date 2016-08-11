using System;

namespace EulerSharp.Problem6
{
    /* Problem Description:
     * The sum of the squares of the first ten natural numbers is 1^2 + 2^2 + ... + 10^2 = 385
     * The square of the sum of the first ten natural numbers is (1 + 2 + ... + 10)^2 = 55^2 = 3025
     * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
     * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
     * 
     * Solution Notes:
     * -
     */

    public static class Program
    {
        public static void Main(string[] args)
        {
            int squareSum = 0; //The sum of the first 100 natural numbers squared individually
            int sum = 0; //The sum of the first 100 natural numbers

            //Loop through the first 100 natural numbers
            for (int n = 1; n <= 100; n++)
            {
                squareSum += n * n; //Add the square of the natural number to the squareSum variable
                sum += n; //Add the natural number itself to the sum variable
            }

            //Calculate the sum of the first 100 natural numbers, squared
            int sumSquared = sum * sum;

            //Calculate the difference (as the difference is always positive or 0, we use the Math.Abs function to get the absolute value)
            int difference = Math.Abs(squareSum - sumSquared);

            //Write the result to the console
            Console.WriteLine("The difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is " + difference);

            //Wait for a keypress before terminating the program (so that the user can read the output)
            Console.ReadKey(true);
        }
    }
}
