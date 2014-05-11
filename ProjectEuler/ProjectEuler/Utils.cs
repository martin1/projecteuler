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
        /// <returns>
        /// List of all primes
        /// </returns>
        public static IEnumerable<int> Primes()
        {
            var ints = Enumerable.Range(2, Int32.MaxValue - 1).Where(x => x % 2 != 0);
            return ints.Where(x => !ints
                                    .TakeWhile(y => y < x)
                                    .Any(y => x % y == 0));
        }
    }
}
