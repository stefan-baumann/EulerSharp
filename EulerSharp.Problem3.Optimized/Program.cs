using System;

namespace EulerSharp.Problem3.Optimized
{
    /* Problem Description:
     * The prime factors of 13195 are 5, 7, 13 and 29.
     * What is the largest prime factor of the number 600851475143?
     * 
     * Solution Notes:
     * - Checking a prime is not necessary if you generate the prime factors directly
     * - Possible factors for a candidate number only have to be checked until the square root of the candidate number.
     * - For faster and accurate factorization, the test number can be divided by each found factor.
     */

    public static class Program
    {
        public static void Main(string[] args)
        {
            long testNumber = 600851475143;
            long number = testNumber; //The number that is worked with
            
            //Loop forever until the loop is exited by the inner code by a break-statement
            while (true)
            {
                long factor = -1; //-1 means that no factor was found; if a factor is found it is stored here

                //Loop through every possible factor (we only have to check until the square root of the test number)
                //This method only generates prime factors
                for (long possibleFactor = 2; possibleFactor * possibleFactor <= number; possibleFactor++)
                {
                    //Check whether this number is a factor of the test number
                    if (number % possibleFactor == 0)
                    {
                        //Store the factor and exit the for-loop
                        factor = possibleFactor;
                        break;
                    }
                }

                //Check whether a factor was found
                if (factor != -1)
                {
                    //A factor was found
                    number /= factor; //Divide the test number by the factor
                }
                else
                {
                    //No factor was found
                    //What remains in the number variable when no factor was found is the biggest prime factor
                    break; //Exit the outter while-loop
                }
            }

            //Write the result to the console
            Console.WriteLine("The biggest prime factor of the number " + testNumber + " is " + number);

            //Wait for a keypress before terminating the program (so that the user can read the output)
            Console.ReadKey(true);
        }
    }
}
