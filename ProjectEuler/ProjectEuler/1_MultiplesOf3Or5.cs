using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    
//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

//Find the sum of all the multiples of 3 or 5 below 1000.

    class MultiplesOf3or5
    {

        public static void RunSolution()
        {
            int sum = 0;

            foreach (var number in getNumbers(1000))
            {
                sum += number;
            }

            Console.WriteLine("sum: {0}", sum);

        }

        public static IEnumerable<int> getNumbers(int upperLimit)
        {
            for (int i = 0; i < upperLimit; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    yield return i;
                }
            }
        }
    }
}
