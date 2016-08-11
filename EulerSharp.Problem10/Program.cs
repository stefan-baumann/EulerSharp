using System;

namespace EulerSharp.Problem10
{
    /* Problem Description:
     * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
     * Find the sum of all the primes below two million.
     * 
     * Solution Notes:
     * - The basic principles on how to find primes is described in the solution to problem #3
     * - Similar problem: #7
     */

    public static class Program
    {
        public static void Main(string[] args)
        {
            long sum = 2; //The sum of all the primes below 2 million (2 is added by default to accomondate for skipping the even prime 2)
            //Increment the candidate by 2 until 2000000 has been reached (even numbers are skipped)
            for (int candidate = 3; candidate < 2000000; candidate += 2)
            {
                //If the candidate is a prime, add it to the sum
                if (IsPrime(candidate))
                {
                    sum += candidate;
                }
            }
            

            //Write the result to the console
            Console.WriteLine("The sum of all primes below 2 million is " + sum);

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
