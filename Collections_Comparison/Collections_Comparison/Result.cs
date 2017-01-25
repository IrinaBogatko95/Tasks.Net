using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Comparison
{
    class Result
    {
        private string executeTime;
        private string nameCollection;
        private string nameOperation;

        public Result(string nameCollection, string nameOperation, string executeTime)
        {
            this.nameCollection = nameCollection;
            this.nameOperation = nameOperation;
            this.executeTime = executeTime;            
        }

        public string GetExecuteTime()
        {
            return executeTime;
        }

        public string GetNameCollection()
        {
            return nameCollection;
        }

        public string GetNameOperation()
        {
            return nameOperation;
        }
    }
}
