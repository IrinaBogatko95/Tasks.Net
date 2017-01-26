using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace task_2_LINQ
{
    class FibonacciSeries
    {
        public IEnumerable<BigInteger> GetFibonacci()
        {
            int Range = 200;
            BigInteger ord1 = 0, ord2 = 0, ord3 = 0;
            IEnumerable<BigInteger> FibSeries = Enumerable.Range(1, Range).Select(a =>
            {
                ord1 = a == 1 ? 0 : ord2;
                ord2 = a == 1 ? 1 : ord3;
                ord3 = a == 1 ? 0 : ord1 + ord2;
                return ord3;
            });
            
            foreach (BigInteger number in FibSeries)
            {
                Console.WriteLine(number);
            }
            
            return FibSeries;
        }
    }
}
