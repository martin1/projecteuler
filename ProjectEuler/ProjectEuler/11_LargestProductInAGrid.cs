using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class LargestProductInAGrid
    {
        public static void RunSolution()
        {
            string filepath = @"C:\Users\KurgiM\Desktop\matrix.txt";
            var matrix = readMatrixFromFile(filepath);

            maxProduct(matrix, 4);


        }

        private static void maxProduct(int[,] matrix, int numberOfElements)
        {
            int maxProduct = 1;
            int rowProduct = 1;
            int colProduct = 1;
            int fallingDiagProduct = 1;
            int risingDiagProduct = 1;
            int iMax  = 0, jMax = 0;
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    colProduct = 1;
                    rowProduct = 1;
                    fallingDiagProduct = 1;
                    risingDiagProduct = 1;

                    for (int k = 0; k < numberOfElements; k++)
                    {
                        if (j + k > matrix.GetUpperBound(0))
                        {
                            colProduct = 1;
                            rowProduct = 1;
                            fallingDiagProduct = 1;
                            risingDiagProduct = 1;
                            break;   
                        }
                        colProduct *= matrix[i, j + k];
                        rowProduct *= matrix[j + k, i];


                        if (i + k > matrix.GetUpperBound(0) || j + k > matrix.GetUpperBound(0) || i-k < 0)
                        {
                            fallingDiagProduct = 1;
                            risingDiagProduct = 1;
                            break;
                        }

                        fallingDiagProduct *= matrix[i + k, j + k];
                        risingDiagProduct *= matrix[i - k, j + k];


                    }


                    //find maxProduct
                    int[] a = {colProduct, rowProduct, risingDiagProduct, fallingDiagProduct};
                    if (a.Max() > maxProduct)
                    {
                        maxProduct = a.Max();
                        iMax = i;
                        jMax = j;
                    }
                    Console.WriteLine("maxProduct: {0} > starting index: {1} , {2}", maxProduct, iMax, jMax);
                }
            }
        }

        private static int[,] readMatrixFromFile(string filepath)
        {
            String input = File.ReadAllText(filepath);

            int i = 0, j = 0;
            int[,] m = new int[20, 20];
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    m[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }
            return m;
        }
    }
}
