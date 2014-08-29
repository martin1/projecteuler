using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{

    //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

    //Find the sum of all the primes below two million.

    class SummationOfPrimes
    {

        public static void RunSolution()
        {

            const int limit = 2000000;
            long sum = 0;

            foreach (var prime in getNextPrime(limit))
                sum += prime;
            Console.WriteLine(sum);
            
        }

        public static IEnumerable<int> getNextPrime(int limit)
        {
            yield return 2;
            foreach (var num in Enumerable.Range(2, Int32.MaxValue - 2).Where(x => x%2 != 0))
            {
                //Console.WriteLine(num);
                if (num >= limit)
                    break;
                if (isPrime(num))
                    yield return num;
            }
        }

        //function taken from Project Euler's problem 7 overview (with even number checking moved to getNextPrime)
        private static bool isPrime(int number)
        {
            if (number < 4)
                return true;

            if (number < 9)
                return true;

            if (number % 3 == 0)
                return false;

            int r = (int) Math.Floor(Math.Sqrt(number));
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
