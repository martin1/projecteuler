using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class _5_SmallestMultiple
    {
        //TODO: not done yet

        public static void RunSolution()
        {
            //TODO: not done yet

            int smallestMultiple = 2;
            //first, multiply all primes from 1 to 20
            foreach (var prime in Primes(20))
            {
                Console.WriteLine(prime);
                smallestMultiple *= prime;
            }
            Console.WriteLine(smallestMultiple);

            //we got 9699690
            //check which numbers do not divide the result evenly
            var ints = Enumerable.Range(1, 20);
            foreach (var val in ints)
            {
                if (smallestMultiple % val != 0)
                {
                    Console.WriteLine(val);
                }
            }
        }


        static IEnumerable<int> Primes(int max)
        {
            var ints = Enumerable.Range(2, Int32.MaxValue - 1).Where(x => x % 2 != 0 && x < max);
            return ints.Where(x => !ints
                                    .TakeWhile(y => y < x)
                                    .Any(y => x % y == 0));
        }
    }
}
