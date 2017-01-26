using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Comparison
{
    /**
     * Adding an item to the collection    
    **/
    abstract class AddItem
    {
        public abstract Result AddToList(List<double> list);

        public abstract Result AddToLinkedList(LinkedList<double> list);

        public abstract Result AddToDictionary(Dictionary<int, double> list);

        public abstract Result AddToQueue(Queue<double> list);

        public abstract Result AddToStack(Stack<double> list);

        public abstract Result AddToSortedSet(SortedSet<double> list);
    
        public abstract Result AddToSortedDictionary(SortedDictionary<int, double> list);
    }
}
