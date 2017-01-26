using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Comparison
{
    /**
     * Reading an item from the collection    
    **/
    abstract class ReadItem
    {
        public abstract Result ReadFromList(List<double> list);

        public abstract Result ReadFromLinkedList(LinkedList<double> list);

        public abstract Result ReadFromDictionary(Dictionary<int, double> list);

        public abstract Result ReadFromQueue(Queue<double> list);

        public abstract Result ReadFromStack(Stack<double> list);

        public abstract Result ReadFromSortedSet(SortedSet<double> list);

        public abstract Result ReadFromSortedDictionary(SortedDictionary<int, double> list);
    }
}
