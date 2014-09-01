using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class LongestCollatzSequence
    {

        //The following iterative sequence is defined for the set of positive integers:

        //n → n/2 (n is even)
        //n → 3n + 1 (n is odd)

        //Using the rule above and starting with 13, we generate the following sequence:
        //13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1

        //It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

        //Which starting number, under one million, produces the longest chain?

        //NOTE: Once the chain starts the terms are allowed to go above one million.
        public static void RunSolution()
        {
            //initial observation indicates that at most only odd numbers should be considered
            //further testing indicates that only those odd numbers where (3*number+1) / 2 is also odd should be considered

            var longestSequenceStart = 0;
            var longestSequenceLength = 0;

            foreach (var n in Enumerable.Range(1, 999999).Where(i => i % 2 != 0 && ((3 * i + 1) / 2) % 2 != 0).Reverse())
            {
                //Console.WriteLine(n + "...");
                var sequenceLength = GetCollatzSequenceLength(n);

                if (sequenceLength > longestSequenceLength)
                {
                    longestSequenceLength = sequenceLength;
                    longestSequenceStart = n;
                    Console.WriteLine(n + " " + longestSequenceLength);
                }
            }
            Console.WriteLine(string.Format("Longest Collatz sequence length under one million is {0} and it starts with \n{1}", 
                longestSequenceLength, longestSequenceStart));
            Console.ReadLine();
        }

        private static int GetCollatzSequenceLength(long startingNumber)
        {
            var length = 0;
            var lastElement = startingNumber;
            while (true)
            {

                length++;
                if (lastElement == 1)
                    break;
                if (lastElement % 2 == 0)
                {
                    lastElement = lastElement / 2;
                }
                else //lastElement is odd
                {
                    lastElement = (3 * lastElement) + 1;
                }
            }
            return length;
        }
    }
}
