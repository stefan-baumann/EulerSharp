using System;

namespace EulerSharp.Problem5
{
    /* Problem Description:
     * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
     * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
     * 
     * Solution Notes:
     * - Checking whether a number x is divisible without a remainder by a number y can be done with x % y == 0
     */

    public static class Program
    {
        public static void Main(string[] args)
        {
            int result = -1; //The variable to store the result in; -1 means no result was found yet
            for (int candidate = 1; result == -1; candidate++) //Increment the candidate until a result was found
            {
                bool isEvenlyDivisible = true;
                //Loop through all possible divisors (1 does not have to be checked as 1 is an even divisor for every number)
                for (int divisor = 2; divisor <= 20; divisor++)
                {
                    //If the candidate is not evenly divisable by the divisor, the candidate does not fit the specifications
                    if (candidate % divisor != 0)
                    {
                        isEvenlyDivisible = false;
                        break; //Exit the inner for-loop as no other divisors have to be checked anymore
                    }
                }

                //Check whether the current candidate meets the requirements
                if (isEvenlyDivisible)
                {
                    result = candidate; //The result is the current number
                }
            }

            //Write the result to the console
            Console.WriteLine("The smallest number which can be divided by each of the numbers from 1 to 20 is " + result);

            //Wait for a keypress before terminating the program (so that the user can read the output)
            Console.ReadKey(true);
        }
    }
}
