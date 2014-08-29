﻿using System;
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

            var longestChainStart = 0;
            var longestChaniLength = 0;

            foreach (var n in Enumerable.Range(3, 999999).Where(_ => _ % 2 != 0).Reverse())
            {
                
            }
        }

        private static List<int> GetCollatzSequence(int startingNumber)
        {
            var sequence = new List<int>();
            var lastElement = startingNumber;
            while (true)
            {
                sequence.Add(lastElement);
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
            return sequence;
        }
    }
}
