using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class HighlyDivisibleTriangularNumber
    {
        public static void RunSolution()
        {
            int maxDivisors = 0;
            foreach (var i in getNextTriangularNumber())
            {
                var a = getNumberOfDivisors(i);
                if (a > maxDivisors)
                {
                    maxDivisors = a;
                    Console.WriteLine(maxDivisors + " " + i);
                }
                //Console.WriteLine(i + " " + getNumberOfDivisors(i));
                if (getNumberOfDivisors(i) > 500)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            //Console.WriteLine(getNumberOfDivisors(28));
        }

        private static IEnumerable<int> getNextTriangularNumber()
        {
            foreach (var number in Enumerable.Range(1, Int32.MaxValue-1))
            {
                yield return number * (number + 1) / 2;
            }
        }

        private static int getNumberOfDivisors(int number)
        {
            int numDivisors = 1;
            if (number % 100 != 0) return 0; // testing showed that numbers mod 10 had a high number of divisors => numbers mod 100 should have even more.
            for (int i = number/2; i >= 1; i--)
            {
                if (number % i == 0)
                {
                    numDivisors++;
                }
            }
            return numDivisors;
        }
    }
}
