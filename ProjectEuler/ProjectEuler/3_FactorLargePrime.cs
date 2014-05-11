using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    //The prime factors of 13195 are 5, 7, 13 and 29.

    //What is the largest prime factor of the number 600851475143 ?
    class FactorLargePrime
    {
        static long bigNumber = 600851475143;
        public static void RunSolution()
        {
            List<int> primeFactors = new List<int>();
            int i = 0;
            while (i < 5)
            {
                if (bigNumber == 1)
                {
                    Console.WriteLine("All Done");
                    break;
                }
                var factor = getFirstPrimeFactor(bigNumber);
                primeFactors.Add(factor);
                bigNumber /= factor;
                i++;
            }
            foreach (var item in primeFactors)
            {
                Console.WriteLine(item);
            }
        }

        static int getFirstPrimeFactor(long bigNumber)
        {
            foreach (var prime in Utils.Primes())
            {
                if (bigNumber % prime == 0)
                {
                    return prime;
                }
            }
            return 1;
        }
    }

}
