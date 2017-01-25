using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Comparison
{
    abstract class DeleteItem
    {
        public abstract Result DeleteFromList(List<double> list);

        public abstract Result DeleteFromLinkedList(LinkedList<double> list);

        public abstract Result DeleteFromDictionary(Dictionary<int, double> list);

        public abstract Result DeleteFromQueue(Queue<double> list);

        public abstract Result DeleteFromStack(Stack<double> list);

        public abstract Result DeleteFromSortedSet(SortedSet<double> list);

        public abstract Result DeleteFromSortedDictionary(SortedDictionary<int, double> list);
    }
}
