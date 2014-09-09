using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Start
    {
        static void Main(string[] args)
        {
            int solutionNumber = 15;

            switch (solutionNumber)
	        {
                case 1:
                    MultiplesOf3or5.RunSolution();
                    break;
                case 2:
                    EvenFibonacci.RunSolution();
                    break;
                case 3:
                    FactorLargePrime.RunSolution();
                    break;
                case 4:
                    LargestPalindromeProduct.RunSolution();
                    break;
                case 5:
                    SmallestMultiple.RunSolution();
                    break;
                case 6:
                    SumSquareDifference.RunSolution();
                    break;
                case 7:
                    TenThousandFirstPrime.RunSolution();
                    break;
                case 8:
                    LargestProductInSeries.RunSolution();
                    break;
                case 9:
                    SpecialPythagoreanTriplet.RunSolution();
                    break;
                case 10:
                    SummationOfPrimes.RunSolution();
                    break;
                case 11:
                    LargestProductInAGrid.RunSolution();
                    break;
                case 12:
                    HighlyDivisibleTriangularNumber.RunSolution();
                    break;
                case 13:
                    LargeSum.RunSolution();
                    break;
                case 14:
                    LongestCollatzSequence.RunSolution();
                    break;
                case 15:
                    LatticePaths.RunSolution();
                    break;
                //...
                case 19:
                    CountingSundays.RunSolution();
                    break;
	        }

        }
    }
}
