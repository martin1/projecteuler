using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectEuler
{
    class LargeSum
    {
        static List<string> rows;
        //Work out the first ten digits of the one-hundred 50-digit numbers in numbers.txt

        public static void RunSolution()
        {
            //brute force solution: sum first n digits of every row where n  in [10,11,12...]
            //testing showed that n=12 is enough
            var fileName = Environment.CurrentDirectory +  @"\..\..\numbers.txt";
            rows = File.ReadAllLines(fileName).ToList();
            Console.WriteLine(CalculateSum(12));
            Console.ReadLine(); // stops console from closing automatically
        }

        private static string CalculateSum(int offset)
        {
            long sum = 0;
            foreach (var row in rows)
            {
                sum += Int64.Parse(row.Substring(0, offset));
            }
            return sum.ToString().Substring(0,10);
        }
    }
}
