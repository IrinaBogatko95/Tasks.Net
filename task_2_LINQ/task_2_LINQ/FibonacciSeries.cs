using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_LINQ
{
    class FibonacciSeries
    {
        public void GetFibonacci()
        {
            Func<long, long, long, IEnumerable<long>> fib = null;
            fib = (n, m, cap) => n + m > cap ? Enumerable.Empty<long>()
                : Enumerable.Repeat(n + m, 1).Concat(fib(m, n + m, cap));

            var list = fib(0, 1, 100000000000000).ToList();

            foreach(var fibEx in list)
            {
                Console.WriteLine(fibEx);
               
            }
            Console.ReadKey();

        }
    }
}
