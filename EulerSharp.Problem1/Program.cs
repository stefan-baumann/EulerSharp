using System;

namespace EulerSharp.Problem1
{
    /* Problem Description:
     * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
     * Find the sum of all the multiples of 3 or 5 below 1000.
     * 
     * Solution Notes:
     * - x is a multiple of y if x % y == 0
     * - x || y evaluates to true of either x or y is true (y is not evaluated if x is true)
     */

    public static class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0; //The sum of all the numbers which are multiples of 3 or 5
            //Loop through all the numbers in the scope (1-999)
            for (int x = 1; x < 1000; x++)
            {
                //Check whether the current number is a multiple of 3 or 5
                if (x % 3 == 0 || x % 5 == 0)
                { 
                   //Add x to the sum
                    sum += x;
                }
            }

            //Write the result to the console
            Console.WriteLine("The sum of all multiples of 3 or 5 below 1000 is " + sum);

            //Wait for a keypress before terminating the program (so that the user can read the output)
            Console.ReadKey(true);
        }
    }
}
