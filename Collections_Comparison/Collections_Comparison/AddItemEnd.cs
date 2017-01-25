using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Comparison
{
/**
* Adding an item to the end of the collection    
**/

class AddItemEnd : AddItem
{
    Random random = new Random();
      Stopwatch readBegin;
        const int _max = 1000000;

        public override Result AddToList(List<double> list)
    {
            readBegin = new Stopwatch();
            readBegin.Start();
            for (int i = 0; i < 100000; i++)
        {
            list.Add(random.Next());
        }
            readBegin.Stop();         
            return new Result(Constants.LIST, Constants.ADD_TO_END, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
    }

    public override Result AddToLinkedList(LinkedList<double> list)
    {
            readBegin = new Stopwatch();
            readBegin.Start();
            for (int i = 0; i < 100000; i++)
        {
            list.AddLast(random.Next());
        }
            readBegin.Stop();

            return new Result(Constants.LINKED_LIST, Constants.ADD_TO_END, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
    }

    public override Result AddToDictionary(Dictionary<int, double> list)
    {
            readBegin = new Stopwatch();
            readBegin.Start();
            for (int i = 0; i < 100000; i++)
        {
                list.Add(i, random.Next());
        }
            readBegin.Stop();

            return new Result(Constants.DICTIONARY, Constants.ADD_TO_END, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
    }

    public override Result AddToQueue(Queue<double> list)
    {
            readBegin = new Stopwatch();
            readBegin.Start();
            for (int i = 0; i < 100000; i++)
        {
            list.Enqueue(random.Next());
        }
            readBegin.Stop();

            return new Result(Constants.QUEUE, Constants.ADD_TO_END, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
    }

    public override Result AddToStack(Stack<double> list)
    {
            readBegin = new Stopwatch();
            readBegin.Start();
           // list.Push(random.Next());
            readBegin.Stop();

            return new Result(Constants.STACK, Constants.ADD_TO_END, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
    }

    public override Result AddToSortedSet(SortedSet<double> list)
    {
            readBegin = new Stopwatch();
            readBegin.Start();
            for (int i = 0; i < 100000; i++)
        {
            list.Add(random.Next());
        }
            readBegin.Stop();

            return new Result(Constants.SORTED_SET, Constants.ADD_TO_END, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
    }

    public override Result AddToSortedDictionary(SortedDictionary<int, double> list)
    {
            readBegin = new Stopwatch();
            readBegin.Start();
            //???
            readBegin.Stop();

            return new Result(Constants.SORTED_DICTIONARY, Constants.ADD_TO_END, ((double)(readBegin.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
    }
}    
}

