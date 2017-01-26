using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Comparison
{
    /**
     * Execute operations with collections  
     **/
    class ExecuteOperations
    {
        List<Result> results;
        Builder builder;
        List<double> list = new List<double>();
        LinkedList<double> linked_list = new LinkedList<double>();
        Dictionary<int, double> dictionary = new Dictionary<int, double>();
        Queue<double> queue = new Queue<double>();
        Stack<double> stack = new Stack<double>();
        SortedSet<double> sortedSet = new SortedSet<double>();
        SortedDictionary<int, double> sortedDictionary = new SortedDictionary<int, double>();
        
        public List<Result> DoAddOperations()
        {           
            builder = new Builder();
            results = new List<Result>();
            List<AddItem> addItems = builder.operationsBuilderAdd();
            foreach (AddItem items in addItems)
            {            
                results.Add(items.AddToList(list));
                results.Add(items.AddToLinkedList(linked_list));
                results.Add(items.AddToDictionary(dictionary));
                results.Add(items.AddToQueue(queue));
                results.Add(items.AddToStack(stack));
                results.Add(items.AddToSortedSet(sortedSet));
                results.Add(items.AddToSortedDictionary(sortedDictionary));
            }     
            return results;
        }

        public List<Result> DoReadOperations()
        {
            results = new List<Result>();
            builder = new Builder();
            List<ReadItem> readItems = builder.operationsBuilderRead();
            foreach (ReadItem items in readItems)
            {
                results.Add(items.ReadFromList(list));
                results.Add(items.ReadFromLinkedList(linked_list));
                results.Add(items.ReadFromDictionary(dictionary));
                results.Add(items.ReadFromQueue(queue));
                results.Add(items.ReadFromStack(stack));
                results.Add(items.ReadFromSortedSet(sortedSet));
                results.Add(items.ReadFromSortedDictionary(sortedDictionary));
            }
            return results;

        }

        public List<Result> DoDeleteOperations()
        {
            results = new List<Result>();
            builder = new Builder();
            List<DeleteItem> deleteItems = builder.operationsBuilderDelete();
            foreach (DeleteItem items in deleteItems)
            {
                results.Add(items.DeleteFromList(list));
                results.Add(items.DeleteFromLinkedList(linked_list));
                results.Add(items.DeleteFromDictionary(dictionary));
                results.Add(items.DeleteFromQueue(queue));
                results.Add(items.DeleteFromStack(stack));
                results.Add(items.DeleteFromSortedSet(sortedSet));
                results.Add(items.DeleteFromSortedDictionary(sortedDictionary));
            }
            return results;
        }
    }
}
