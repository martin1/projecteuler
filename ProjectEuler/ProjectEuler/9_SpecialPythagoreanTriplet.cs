using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{  

//A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
//a^2 + b^2 = c^2

//For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

//There exists exactly one Pythagorean triplet for which a + b + c = 1000.
//Find the product abc.

    class SpecialPythagoreanTriplet
    {
        public static void RunSolution()
        {

            //What is known: a + b + c = 1000,
            //a + b > c => c < 500
            //Euclid's formula states that
            //a = m^2 - n^2, 
            //b = 2 * m * n,
            //c = m^2 + n^2  => so in this case (m^2 + n^2) < 500 => m and n < sqrt(500) which should limit the loops nicely.

            int limit = 1000;
            int a;
            int b;
            int c;
            int loopLimit = (int) Math.Sqrt(limit/2);

                for (int n = 1; n < loopLimit; n++)
                {
                    for (int m = 1; m < loopLimit; m++)
                    {

                        a = (int)(Math.Pow(m, 2) - Math.Pow(n, 2));
                        b = 2*m*n;
                        c = (int) (Math.Pow(m, 2) + Math.Pow(n, 2));
                        //Console.WriteLine(a);
                        if (a + b + c == limit)
                        {
                            Console.WriteLine(a + " " + b + " " + c);
                        }
                    }
                }
            Console.WriteLine("Product: {0}", 375 * 200 * 425);
        }
    }
}
