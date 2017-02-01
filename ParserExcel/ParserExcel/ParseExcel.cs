using System;
using System.Collections.Generic;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;

namespace ParserExcel
{
    public static class ParseExcel
    {
        public static Excel.Worksheet xlWorksheet;
        public static Excel.Workbook xlWorkbook;
        public static Header header;
        public static Excel.Range xlRange;
        public static object[,] valueArray;
        public static Journal journal;

        public static List<Journal> Parser(String path)
        {
            // Reference to Excel Application.
            Excel.Application xlApp = new Excel.Application();
            xlWorkbook = xlApp.Workbooks.Open(Path.GetFullPath(path));
            List<Journal> allJournals = new List<Journal>();

            //Add all journals to list
            for (int i = 1; i <= xlWorkbook.Sheets.Count; i++)
            {
                xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(i);
                // Get the range of cells which has data.
                xlRange = xlWorksheet.UsedRange;

                // Get an object array of all of the cells in the worksheet with their values.
                valueArray = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

                journal = new Journal(xlWorksheet.Name);
                allJournals.Add(ParseExcel.ParseJournal(xlWorksheet));
            }

            // Close the Workbook.
            xlWorkbook.Close(false);

            // Relase COM Object by decrementing the reference count.
            Marshal.ReleaseComObject(xlWorkbook);

            // Close Excel application.
            xlApp.Quit();

            // Release COM object.
            Marshal.FinalReleaseComObject(xlApp);
            if(allJournals != null)
            {
                return (List<Journal>) allJournals;
            }
            return null;        
        }

        //Parse and return new journal
        public static Journal ParseJournal(Excel.Worksheet worksheet)
        {
            int col = 1;
            header = new Header();
                while ( xlRange.Cells[col, 2].Value != null)
                {
                    header.HeaderName = valueArray[col, 2].ToString();
                    int row = 3;
                    while (xlRange.Cells[col, row].Value != null)
                    {
                     header.AddItem(new HeaderItem(valueArray[col, row].ToString()));
                    //header.Items.Add(new HeaderItem(valueArray[col, row].ToString()));
                    ++row;
                }
                journal.AddHeader(header);
                
                ++col;
            }
                
                        
            return journal;
        }
    }
}
