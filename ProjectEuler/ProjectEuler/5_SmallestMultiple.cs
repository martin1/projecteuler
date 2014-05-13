using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class SmallestMultiple
    {
       
    //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

    //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?


        public static void RunSolution()
        {

            int num = 1;
            //multiply all primes 2..20 and go from there
            foreach (var prime in Utils.getNextPrime(20))
            {
                num *= prime;
            }
            //num = 4849845
            IsNumDividedByAll(num);
            //Num is not evenly dividable by 2,4,6,8,9,10,12,14,16,18,20
            //fine tuning...
            num *= 4;
            num *= 3;
            num *= 4;

            Console.WriteLine("Checking {0}: {1}", num, IsNumDividedByAll(num));

        }
  
        /// <summary>
        /// Prints out numbers from 2..20 which do not evenly divide the number to be checked
        /// </summary>
        /// <param name="numberToBeChecked">Number that is checked for even divisibility by numbers 2..20</param>
        /// <returns>True if given number is evenly divisible by all numbers from 2..20, false otherwise</returns>
        public static bool IsNumDividedByAll(int numberToBeChecked)
        {
            var nums = Enumerable.Range(2, 19);
            List<int> notDivided = new List<int>();
            Console.WriteLine("Checking {0}...", numberToBeChecked);
            foreach (var num in nums)
            {
                if (numberToBeChecked % num != 0)
                {
                    notDivided.Add(num);
                }
            }

            if (notDivided.Count > 0)
            {
                Console.WriteLine("Number not evenly dividable by:");
                foreach (var item in notDivided)
                {
                    Console.WriteLine(item);
                }
                return false;
            }
            return true;
        }
    }
}
