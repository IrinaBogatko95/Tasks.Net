using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace task_2_LINQ
{
    public static class BigIntegerExtension
    {
        public static void SimplicityCheck(this BigInteger someInt, IEnumerable<BigInteger> FibSeries)
        {
            int counter = 0;
            foreach (BigInteger number in FibSeries)
            {
                for (int i = 2; i <= (int)(Math.Sqrt(number) / 2); i++)
                {
                    if (!(number % i == 0))
                        counter++;
                }                
            }
            Console.WriteLine("In the sequence " + counter + " prime numbers");
        }
    }
}
