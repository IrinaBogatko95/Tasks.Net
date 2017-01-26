using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Comparison
{
    /**
    * Writing result of exeting collection in txt-file  
    **/
    class ResultInFile
    {
        public const string PATH = "D:/File.txt";
        string spaces = "            ";

        public void WriteToFile(List<Result> resultsToAdd, List<Result> resultsToRead, List<Result> resultsToDelete)
        {       
            StreamWriter sw = new StreamWriter(PATH, false, System.Text.Encoding.Default);
          
            foreach (Result resultsToWrite in resultsToAdd)
            {                               
                sw.WriteLine($"Operation: {resultsToWrite.GetNameOperation()}{spaces}\nCollection: {resultsToWrite.GetNameCollection()}{spaces}executed time: {resultsToWrite.GetExecuteTime()}"); 
                sw.WriteLine("-----------------------------------------------------------------------------------------");                     
            }
                        
            foreach (Result resultsToWrite in resultsToRead)
            {
                sw.WriteLine("Operation: " + resultsToWrite.GetNameOperation() + spaces +
                     "Collection: " + resultsToWrite.GetNameCollection() + spaces + " executed time: " + resultsToWrite.GetExecuteTime());
                sw.WriteLine("----------------------------------------------------------------------------------------");
            }
           
            foreach (Result resultsToWrite in resultsToDelete)
            {
                sw.WriteLine("Operation: " + resultsToWrite.GetNameOperation() + spaces +
                                    "Collection: " + resultsToWrite.GetNameCollection() + spaces + " executed time: " + resultsToWrite.GetExecuteTime());
                sw.WriteLine("----------------------------------------------------------------------------------------");
            }
            sw.Close();
        }
    }
}
