using System;
using System.Collections.Generic;
using System.Numerics;

namespace FibonachiNumbers
{
    public static class Fibonachi
    {
        public static IEnumerable<BigInteger> FibonachiNum(int number)
        {
            BigInteger first = -1;
            BigInteger next = 1;
            for (int i = 0; i < number; i++)
            {
                BigInteger temp = next;
                next += first;
                first = temp;
                yield return next;
            }
        }
    }
}
