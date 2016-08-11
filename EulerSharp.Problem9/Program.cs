using System;

namespace EulerSharp.Problem9
{
    /* Problem Description:
     * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which a^2 + b^2 = c^2
     * For example 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
     * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
     * Find the product abc.
     * 
     * Solution Notes:
     * - Checking whether a number x has decimal places can be easily done by checking x % 1 == 0
     * - x && y evaluates to true if x and y are true (y is not evaluated if x is false)
     */

    public static class Program
    {
        public static void Main(string[] args)
        {
            //Increment a and b until the product has been found (b will only be incremented to 1000 before a will be incremented again)
            int product = -1; //The variable in which the product will be stored; -1 means the product has not been found yet
            for (int a = 1; product == -1; a++)
            {
                for (int b = 1; b < 1000 && product == -1; b++)
                {
                    //Check whether a natural number c exists for the following scheme: c = sqrt(a^2 + b^2)
                    double c = Math.Sqrt(a * a + b * b); //Calculate c
                    if (c % 1 == 0) //Check whether c has no decimal places
                    {
                        //Pythagorean triplet found, check whether the sum of a, b and c is 1000
                        if (a + b + c == 1000)
                        {
                            //Calculate the product
                            product = a * b * (int)c;
                        }
                    }
                }
            }

            //Write the result to the console
            Console.WriteLine("The product of the pythagorean triplet for which the sum of a, b and c is 1000 is " + product);

            //Wait for a keypress before terminating the program (so that the user can read the output)
            Console.ReadKey(true);
        }
    }
}
