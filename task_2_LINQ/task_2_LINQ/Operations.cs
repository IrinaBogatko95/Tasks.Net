﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace task_2_LINQ
{
    class Operations
    {
        public void numbersDividedFive(IEnumerable<BigInteger> FibSeries)
        {
            foreach (BigInteger number in FibSeries)
            {
               if(number % 5 == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sequence have numbers that are divisible by 5");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
