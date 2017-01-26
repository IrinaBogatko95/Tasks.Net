using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace task_2_LINQ
{
    public static class BigIntegerExtension
    {
        public static bool SimplicityCheck(this BigInteger someInt, BigInteger number)
        {
            for (int i = 2; i <= (int)(number.SqrtBigInt() / 2); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }


        public static BigInteger SqrtBigInt(this BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);

                while (!isSqrt(n, root))
                {
                    root += n / root;
                    root /= 2;
                }

                return root;
            }

            throw new ArithmeticException("NaN");
        }

        private static Boolean isSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound && n < upperBound);
        }
    }

}
