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

            foreach (var prime in Utils.getNextPrime(limit))
                sum += prime;

            Console.WriteLine(sum);
        }

    }
}
