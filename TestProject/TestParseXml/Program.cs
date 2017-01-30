using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.CSharp;
using System.IO;
using System.Runtime.InteropServices;

namespace TestParseXml
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<string> list = new List<string>();
            List<Header> headers = new List<Header>();
            List<HeaderItem> headersitem = new List<HeaderItem>();
            Journal journal;
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open("D:\\Framework\\Styling\\Responsive-Batch-3.xlsx");
            Excel._Worksheet xlWorksheet;
            for (int k = 1; k < xlWorkbook.Worksheets.Count; k++)
            {
                 xlWorksheet = xlWorkbook.Sheets[k];
                Excel.Range xlRange = xlWorksheet.UsedRange;
                journal = new Journal(xlWorksheet.Name);

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;

                //iterate over the rows and columns and print to the console as it appears in the file
                //excel is not zero based!!    

                    for (int i = 1; i <= colCount; i++)
                    {
                        for (int j = 1; j <= rowCount; j++)
                        {
                        if (i == 2)
                        {
                            headers.Add(xlRange.Cells[i, j].Value2.ToString());
                        }
                        else
                        {
                            headersitem.Add(xlRange.Cells[i, j].Value2.ToString());
                        }
                     }
                 }
                                                                                                        

                foreach (string res in list)
                {
                    Console.WriteLine(res);

                }

                // Console.ReadKey();

                //cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:
                //  never use two dots, all COM objects must be referenced and released individually
                //  ex: [somthing].[something].[something] is bad

                //release com objects to fully kill excel process from running in the background
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);
            }

                //close and release
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                //quit and release
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            
        }
    }
}
