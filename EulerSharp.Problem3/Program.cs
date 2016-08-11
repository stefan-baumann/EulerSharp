using System;

namespace EulerSharp.Problem3
{
    /* Problem Description:
     * The prime factors of 13195 are 5, 7, 13 and 29.
     * What is the largest prime factor of the number 600851475143?
     * 
     * Solution Notes:
     * - x is a multiple of y if x % y == 0. So y is a factor of x if x % y == 0.
     * - A number x is prime if there is no number y which is a factor of x except 1 and x itself. So x % y may not be 0 for any possible value for y except 1 and x
     * - x && y evaluates to true if x and y are true (y is not evaluated if x is false)
     * - While this solution should be easy to understand for everyone, it is not suited for this problem. See the EulerSharp.Problem3.Optimized project for an actually useful implementation.
     */

    public static class Program
    {
        public static void Main(string[] args)
        {
            long testNumber = 600851475143; //We have to use a long (64-bit integer) because the number is too big for an int (32-bit integer)

            //Store the current biggest prime factor in a variable
            long biggestPrimeFactor = 1;
            for (long factor = 2; factor < (testNumber / 2); factor++)
            {
                //Check whether the current number is a factor of the main number and whether it is a prime
                if (testNumber % factor == 0 && IsPrime(factor))
                {
                    //If it is a factor and a prime, it is the new biggest prime factor
                    biggestPrimeFactor = factor;
                }
            }

            //Write the result to the console
            Console.WriteLine("The biggest prime factor of the number " + testNumber + " is " + biggestPrimeFactor);

            //Wait for a keypress before terminating the program (so that the user can read the output)
            Console.ReadKey(true);
        }

        public static bool IsPrime(long candidate)
        {
            //Check manually for 1
            if (candidate == 1)
            {
                return true; //Return true as 1 is a prime
            }

            //Loop through every number from 2 to (candidate / 2) as no number above the half of the candidate can be a factor of it
            for (long test = 2; test <= candidate / 2; test++)
            {
                if (candidate % test == 0) //Check whether the current number is a factor of the candidate
                {
                    return false;
                }
            }

            //If it ran through the check successfully it is definitely a prime
            return true;
        }
    }
}
