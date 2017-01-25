using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {           
            ExecuteOperations executeOperations = new ExecuteOperations();           
            List<Result> resultsAdd = executeOperations.DoAddOperations();
            List<Result> resultsRead = executeOperations.DoReadOperations();
            List<Result> resultsDelete = executeOperations.DoDeleteOperations();
            ResultInFile result_in_file = new ResultInFile();
            result_in_file.WriteToFile(resultsAdd, resultsRead, resultsDelete);
        }
    }
}
