using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Utils
    {
        /// <summary>
        /// Calculate all Primes lazily
        /// </summary>
        /// <returns>consecutive primes</returns>

        public static IEnumerable<int> getNextPrime(int limit = 0)
        {
            yield return 2;
            foreach (var num in Enumerable.Range(2, Int32.MaxValue - 1).Where(x => x % 2 != 0))
                if ( limit != 0 && num >= limit)
                    break;
                else
                    if (isPrime(num))
                        yield return num;
        }

        //function taken from Project Euler's problem 7 overview (with even number check moved to getNextPrime)
        private static bool isPrime(int number)
        {
            if (number < 4)
                return true;

            if (number < 9)
                return true;

            if (number % 3 == 0)
                return false;

            int r = (int)Math.Floor(Math.Sqrt(number));
            int f = 5;

            while (f <= r)
            {
                if (number % f == 0)
                    return false;
                if (number % (f + 2) == 0)
                    return false;
                f += 6;
            }
            return true;
        }
    }
}
