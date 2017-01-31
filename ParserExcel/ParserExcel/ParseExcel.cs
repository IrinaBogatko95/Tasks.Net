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

        public static void Parser(String path)
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
        }

        //Parse and return new journal
        public static Journal ParseJournal(Excel.Worksheet worksheet)
        {

            for (int col = 1; col <= worksheet.UsedRange.Columns.Count; ++col)
            {
                header = new Header();
                if (xlRange.Cells[2, col] != null && xlRange.Cells[2, col].Value2 != null)
                {
                    header.HeaderName = valueArray[2, col].ToString();
                }
                for (int row = 3; row <= worksheet.UsedRange.Rows.Count; ++row)
                {
                    if (xlRange.Cells[row, col] != null && xlRange.Cells[row, col].Value2 != null)
                    {
                        header.AddItem(new HeaderItem(valueArray[row, col].ToString()));
                    }
                    else
                    {
                        break;
                    }
                }
                journal.AddHeader(header);
            }
            return journal;
        }
    }
}
