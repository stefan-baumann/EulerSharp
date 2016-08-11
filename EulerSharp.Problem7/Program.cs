using System;

namespace EulerSharp.Problem7
{
    /* Problem Description:
     * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
     * What is the 10 001st prime number?
     * 
     * Solution Notes:
     * - The basic principles on how to find primes is described in the solution to problem #3
     */

    public static class Program
    {
        public static void Main(string[] args)
        {
            int primeCount = 1; //The prime number count (1 because we skipped 2
            int result = -1; //The variable where the 10001st prime will be stored in
            //Increment the candidate by 2 until the 10001st prime has been found (even numbers are skipped)
            for (int candidate = 3; primeCount < 10001; candidate += 2)
            {
                //Check whether this candidate is prime
                if (IsPrime(candidate))
                {
                    primeCount++; //Increment the prime counter
                    if (primeCount == 10001)
                    {
                        //If this is the 10001st prime, this is the result we were looking for
                        result = candidate;
                    }
                }
            }

            //Write the result to the console
            Console.WriteLine("The 10001st prime is " + result);

            //Wait for a keypress before terminating the program (so that the user can read the output)
            Console.ReadKey(true);
        }

        public static bool IsPrime(long candidate)
        {
            //Loop through every number from 2 to sqrt(candidate) as no number above the square root of the candidate can be a factor of it, if there wasn't one before that
            for (long test = 2; test * test <= candidate; test++)
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
