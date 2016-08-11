using System;
using System.Linq;

namespace EulerSharp.Problem4
{
    /* Problem Description:
     * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
     * Find the largest palindrome made from the product of two 3-digit numbers.
     * 
     * Solution Notes:
     * - A simple way to check a number for being a palindrome is to generate the string representation of it, reverse the characters and check whether it is still the same.
     */

    public static class Program
    {
        public static void Main(string[] args)
        {
            int biggestPalindrome = -1; //The variable to store the biggest found palindrome number in
            //Loop through all 3-digit numbers
            for (int a = 100; a <= 999; a++)
            {
                //Loop through all 3-digit numbers
                for (int b = 100; b <= 999; b++)
                {
                    //Calculate the product of the two numbers a and b and check whether it is palindromic & bigger than the current biggest palindrome
                    int product = a * b;
                    if (IsPalindrome(product) && product > biggestPalindrome)
                    {
                        biggestPalindrome = product; //Set the current highest palindrome
                    }
                }
            }

            //Write the result to the console
            Console.WriteLine("The largest palindrome made from the product of two 3-digit numbers is " + biggestPalindrome);

            //Wait for a keypress before terminating the program (so that the user can read the output)
            Console.ReadKey(true);
        }

        //A simple function for checking whether a number is palindromic
        public static bool IsPalindrome(int candidate)
        {
            //Parse the reverse version of the string representatino of the candidate
            int reverse = int.Parse(new string(candidate.ToString().Reverse().ToArray()));
            //Check whether the candidate and its reverse representation are equal
            return candidate == reverse;
        }
    }
}
