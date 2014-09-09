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

        //NOTE: incomplete solution, works only when the binary value of squareSize*2 <= Int32.MaxValue
        const int squareSize = 5;

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
            foreach (var item in paths)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
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
