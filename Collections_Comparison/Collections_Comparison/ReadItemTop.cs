using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Comparison
{
    /**
    * Reading an item from the top of the collection    
    **/
    
    class ReadItemTop : ReadItem
    {
        const int _max = 1000000;
        Stopwatch readBegin;
        Random random = new Random();

        public override Result ReadFromList(List<double> list)
        {
            readBegin = new Stopwatch();
            readBegin.Start();
            list.First();
            readBegin.Stop();

            return new Result(Constants.LIST, Constants.READ_FROM_TOP, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        }

        public override Result ReadFromLinkedList(LinkedList<double> list)
        {
            readBegin = new Stopwatch();
            readBegin.Start();
            list.First();
            readBegin.Stop();

            return new Result(Constants.LINKED_LIST, Constants.READ_FROM_TOP, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        }

        public override Result ReadFromDictionary(Dictionary<int, double> list)
        {
            readBegin = new Stopwatch();
            readBegin.Start();
            list.First();        
            readBegin.Stop();

            return new Result(Constants.DICTIONARY, Constants.READ_FROM_TOP, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        }

        public override Result ReadFromQueue(Queue<double> list)
        {
            readBegin = new Stopwatch();
            for (int i = 0; i < 100; i++)
            {
                list.Enqueue(random.Next());
            }
            readBegin.Start();
            list.Peek();
            readBegin.Stop();

            return new Result(Constants.QUEUE, Constants.READ_FROM_TOP, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        }

        public override Result ReadFromStack(Stack<double> list)
        {
            readBegin = new Stopwatch();
            for (int i = 0; i < 100; i++)
            {
                list.Push(random.Next());
            }
            readBegin.Start();
             list.First();
            readBegin.Stop();

            return new Result(Constants.STACK, Constants.READ_FROM_TOP, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        }

        public override Result ReadFromSortedSet(SortedSet<double> list)
        {
            readBegin = new Stopwatch();
            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next());
            }
            readBegin.Start();
            list.First();
            readBegin.Stop();

            return new Result(Constants.SORTED_SET, Constants.READ_FROM_TOP, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        }

        public override Result ReadFromSortedDictionary(SortedDictionary<int, double> list)
        {
            readBegin = new Stopwatch();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i, random.Next());
            }
            readBegin.Start();
            list.First();
            readBegin.Stop();

            return new Result(Constants.SORTED_DICTIONARY, Constants.READ_FROM_TOP, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        }
    }
}
