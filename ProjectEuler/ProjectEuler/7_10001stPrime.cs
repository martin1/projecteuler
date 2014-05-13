using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class TenThousandFirstPrime
    {

        public static void RunSolution()
        {
            int i = 2;
            foreach (var prime in Utils.getNextPrime())
            {
                i++;
                if (i == 10001)
                {
                    Console.WriteLine(i + ": " + prime);
                    break;
                }
            }
        }
    }
}
