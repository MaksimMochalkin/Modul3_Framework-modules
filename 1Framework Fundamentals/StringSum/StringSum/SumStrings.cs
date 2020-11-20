using System;
using System.Numerics;

namespace StringSum
{
    public static class SumStrings
    {
        public static string SumAnyStringNumber(string first, string second)
        {
            
            BigInteger firstBigInt = 0;
            BigInteger secondBigInt = 0;
            BigInteger.TryParse(first, out firstBigInt);
            BigInteger.TryParse(second, out secondBigInt);

            return (firstBigInt + secondBigInt).ToString();
        }
    }
}
