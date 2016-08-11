using System;

namespace EulerSharp.Problem8
{
    /* Problem Description:
     * The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
     * [...]
     * Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
     * 
     * Solution Notes:
     * -
     */

    public static class Program
    {
        public static void Main(string[] args)
        {
            string bigNumber = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";

            long greatestProduct = 0; //The greatest product of 13 adjacent digits found so far (we use a long (int64) here to ensure that the product can fit in)
            //Loop through all the indexes which are more than 13 digits away from the end of the string
            for (int i = 0; i < bigNumber.Length - 12; i++)
            {
                //Extract the appropriate part of the string
                string section = bigNumber.Substring(i, 13);

                //Calculate the product
                long product = 1;
                //Loop through each character in the section and multiply it's value to the product
                for (int j = 0; j < 13; j++)
                {
                    product *= int.Parse(section[j].ToString());
                }

                //Check whether the current product is bigger than the previous greatest product
                if (product > greatestProduct)
                {
                    greatestProduct = product;
                }
            }

            //Write the result to the console
            Console.WriteLine("The greatest product of 13 adjacent digits is " + greatestProduct);

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
