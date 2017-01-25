using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace task_2_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciSeries fib = new FibonacciSeries();
            IEnumerable<BigInteger> fibSeries = fib.GetFibonacci();

            BigInteger bigInt = new BigInteger();
            bigInt.SimplicityCheck(fibSeries);

            Operations operations = new Operations();
            operations.numbersDividedFive(fibSeries);
            

                    
        }
    }
}
