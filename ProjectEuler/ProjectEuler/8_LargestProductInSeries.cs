using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class LargestProductInSeries
    {
        static readonly string sourceText = System.IO.File.ReadAllText(@"C:\dev\git\projecteuler\ProjectEuler\ProjectEuler\source.txt");

        public static void RunSolution()
        {
            int maxProduct = 1;
            foreach (var product in getNumberProducts(sourceText))
            {
                if (product > maxProduct)
                    maxProduct = product;
            }
            Console.WriteLine("Max Product: {0}", maxProduct);
        }


        public static IEnumerable<int> getNumberProducts(string numberAsText)
        {
            for (int i = 0; i < numberAsText.Length-4; i++)
            {
                int product = 1;
                foreach (char c in numberAsText.Substring(i, 5))
                {
                    product *= (int) char.GetNumericValue(c);
                }
                yield return product;
            }
        }
    }
}
