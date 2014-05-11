using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    //A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

    //Find the largest palindrome made from the product of two 3-digit numbers.
    class LargestPalindromeProduct
    {

        public static void RunSolution()
        {
            int a = 2002;
            Console.WriteLine(2002.ToString().Length);

            //get iterator over all 3-digit numbers
            var nums = Enumerable.Range(100, 900);
            int product;
            string numString;
            string beginning;
            string end;
            int maxPalindrome = 0;
            foreach (var outer in nums)
            {
                foreach (var inner in nums)
                {
                    product = outer * inner;
                    numString = product.ToString();

                    if (numString[numString.Length - 1] == 0)
                    {
                        continue;
                    }
                    if (numString.Length % 2 == 0)
                    {
                        beginning = numString.Substring(0, (numString.Length) / 2);
                        end = numString.Substring((numString.Length) / 2);
                        if (beginning.Equals(reverseString(end)))
                        {
                            // Console.WriteLine(product);
                        }
                        //Console.WriteLine("product: {0} beginning: {1} end: {2}", product, beginning, end);
                    }
                    else // numString.Length % 2 == 1
                    {
                        beginning = numString.Substring(0, (int)(numString.Length / 2));
                        end = numString.Substring((int)numString.Length / 2 + 1);
                        //Console.WriteLine("product: {0} beginning: {1} end: {2}", product, beginning, end);
                    }

                    if (beginning.Equals(reverseString(end)))
                    {
                        //Console.WriteLine(product);
                        Console.WriteLine("product: {0} beginning: {1} end: {2}", product, beginning, end);
                        if (product > maxPalindrome)
                        {
                            maxPalindrome = product;
                        }
                    }

                }
            }
            Console.WriteLine("MaxPalindrome: {0}", maxPalindrome);
        }
        private static string reverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
