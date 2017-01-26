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

            Operations operations = new Operations();
            operations.numbersDividedFive(fibSeries);
            operations.primeNumbers(fibSeries);                       
        }
    }
}
