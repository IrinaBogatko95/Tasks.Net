using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.CSharp;
using System.IO;
using System.Runtime.InteropServices;

namespace TestParseXml
{
    class TestClass
    {
        public void someMethod()
        {

            // Reference to Excel Application.
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(Path.GetFullPath("C:\\Users\\irina\\Documents\\additionals\\Styling\\Responsive-Batch-3.xlsx"));

            // Get the first worksheet.
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(1);

            // Get the range of cells which has data.
            Excel.Range xlRange = xlWorksheet.UsedRange;

            // Get an object array of all of the cells in the worksheet with their values.
            object[,] valueArray = (object[,])xlRange.get_Value(
                        Excel.XlRangeValueDataType.xlRangeValueDefault);

            List<Header> headers = new List<Header>();
            List<HeaderItem> items = new List<HeaderItem>();
            List<Journal> journal = new List<Journal>();
            // iterate through each cell and display the contents.

            for (int col = 1; col <= xlWorksheet.UsedRange.Columns.Count; ++col)
            {
                for (int row = 2; row <= xlWorksheet.UsedRange.Rows.Count; ++row)
                {
                    if (xlRange.Cells[row, col] != null && xlRange.Cells[row, col].Value2 != null)
                    {
                        items.Add(new HeaderItem(valueArray[row, col].ToString()));
                            
                    }
                    else
                    {
                        headers.Add(new Header(items));
                        break;
                    }
                   
                }
            }
            journal.Add(new Journal(xlWorksheet.Name, headers));

           


                    Console.WriteLine(headers.ElementAt(0).getAllHeaders());
                
                
            

            // Close the Workbook.
            xlWorkbook.Close(false);

            // Relase COM Object by decrementing the reference count.
            Marshal.ReleaseComObject(xlWorkbook);

            // Close Excel application.
            xlApp.Quit();

            // Release COM object.
            Marshal.FinalReleaseComObject(xlApp);

            Console.ReadLine();
        }
    }
}
