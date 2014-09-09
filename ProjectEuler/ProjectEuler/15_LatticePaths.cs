using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class LatticePaths
    {
        

    //Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, 
    //there are exactly 6 routes to the bottom right corner.

    //How many such routes are there through a 20×20 grid?

        //Solution: using central binomial coefficient: (factorial 40) / (factorial 20)**2 = 137846528820
        //As the incomplete solution gives us the number of paths for 2, 3, 4, 5 sided squares I used googled the numbers of paths
        //which led to binomial coefficient wiki page with the formula (factorial n) / (factorial n)**2, where n >= 0.
        //Calculated using Wolfram Alpha
        const int squareSize = 4;

        public static void RunSolution()
        {
            var paths = new List<int>();
            var maxValue = GetMaxValue(squareSize * 2);
            foreach (var num in Enumerable.Range(1, maxValue))
            {
                var numBinary = Convert.ToString(num, 2).PadLeft(squareSize * 2, '0');
                if (numBinary.Length > squareSize * 2)
                {
                    break;
                }
                if (numBinary.Count(c => c == '0') == squareSize && !paths.Contains(num))
                {
                    paths.Add(num);
                }
            }
            Console.WriteLine("Square size: " + squareSize + "\nnumber of different paths: " + paths.Count);
            Console.ReadLine();
            Console.WriteLine("20-sided square has 137846528820 possible paths. See comments at LatticePaths class for details");
        }

        private static int GetMaxValue(int squareSize)
        {
            string value = "";
            for (int i = 0; i < squareSize; i++)
            {
                value += "1";
            }
            return Convert.ToInt32(value, 2);
        }

    }

}
