using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Comparison
{
    class Builder
    {

        public List<AddItem> operationsBuilderAdd()
        {
            List<AddItem> addItem = new List<AddItem>();
            addItem.Add(new AddItemTop());
            addItem.Add(new AddItemEnd());

            return addItem;
        }
       
       public List<ReadItem> operationsBuilderRead()
       {
           List<ReadItem> readItem = new List<ReadItem>();
           readItem.Add(new ReadItemTop());
           readItem.Add(new ReadItemEnd());

           return readItem;
       }

       public List<DeleteItem> operationsBuilderDelete()
       {
           List<DeleteItem> deleteItem = new List<DeleteItem>();
           deleteItem.Add(new DeleteItemTop());
           deleteItem.Add(new DeleteItemEnd());

           return deleteItem;
       }
    }
}
