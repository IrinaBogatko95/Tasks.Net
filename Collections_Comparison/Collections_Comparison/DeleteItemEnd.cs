using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Comparison
{
    /**
    * Delete an item from the end of the collection    
    **/
   
    class DeleteItemEnd : DeleteItem
    {
        Stopwatch readBegin;
        const int _max = 1000000;

        public override Result DeleteFromList(List<double> list)
        {
            readBegin = new Stopwatch();
            readBegin.Start();
            list.Remove(100000);
            readBegin.Stop();

            return new Result(Constants.LIST, Constants.DELETE_FROM_END, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        }

        public override Result DeleteFromLinkedList(LinkedList<double> list)
        {
            readBegin = new Stopwatch();
            readBegin.Start();
            list.RemoveLast();
            readBegin.Stop();

            return new Result(Constants.LINKED_LIST, Constants.DELETE_FROM_END, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        }

        public override Result DeleteFromDictionary(Dictionary<int, double> list)
        {
            readBegin = new Stopwatch();
            readBegin.Start();
           // list.Remove();
            readBegin.Stop();

            return new Result(Constants.DICTIONARY, Constants.DELETE_FROM_END, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        }

        public override Result DeleteFromQueue(Queue<double> list)
        {
            readBegin = new Stopwatch();
            readBegin.Start();
            //list.Dequeue();
            readBegin.Stop();

            return new Result(Constants.QUEUE, Constants.DELETE_FROM_END, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        }

        public override Result DeleteFromStack(Stack<double> list)
        {
            readBegin = new Stopwatch();
            readBegin.Start();
            //list.Pop();
            readBegin.Stop();

            return new Result(Constants.STACK, Constants.DELETE_FROM_END, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        }

        public override Result DeleteFromSortedSet(SortedSet<double> list)
        {
            readBegin = new Stopwatch();
            readBegin.Start();
            list.Remove(100000);
            readBegin.Stop();

            return new Result(Constants.SORTED_SET, Constants.DELETE_FROM_END, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        }

        public override Result DeleteFromSortedDictionary(SortedDictionary<int, double> list)
        {
            readBegin = new Stopwatch();
            readBegin.Start();
            list.Remove(0);
            readBegin.Stop();

            return new Result(Constants.SORTED_DICTIONARY, Constants.DELETE_FROM_END, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        }

    }
}
