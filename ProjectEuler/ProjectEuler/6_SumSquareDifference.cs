using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class SumSquareDifference
    {

        //The sum of the squares of the first ten natural numbers is,
        //1^2 + 2^2 + ... + 10^2 = 385

        //The square of the sum of the first ten natural numbers is,
        //(1 + 2 + ... + 10)^2 = 55^2 = 3025

        //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

        //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

        //Brute force implementation
        public static void RunSolution()
        {
            int sum = 0;
            int sumOfSquares = 0;
            foreach (var num in Enumerable.Range(1, 100))
            {
                sumOfSquares += num * num;
                sum += num;
            }
            var squareOfSum = sum * sum;
            Console.WriteLine("SquareOfSum - SumOfSquares = {0}", squareOfSum - sumOfSquares);


        }
    }
}
