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
        public static Header header;
        public static HeaderItem headerItem;
        public static Excel.Range xlRange; 

        public static List<Journal> Parser()
        {
            Excel.Worksheet xlWorksheet;
            Excel.Workbook xlWorkbook;
            List<Journal> allJournals = new List<Journal>();
            Journal journal;       
            // Reference to Excel Application.
            Excel.Application xlApp = new Excel.Application();
            xlWorkbook = xlApp.Workbooks.Open(Path.GetFullPath(Settings1.Default.Path));
            //Add all journals to list
            for (int i = 1; i <= xlWorkbook.Sheets.Count; i++)
            {
                xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(i);
                journal = new Journal(xlWorksheet.Name);

                // Get the range of cells which has data.
                xlRange = xlWorksheet.UsedRange;
                ParseExcel.ParseJournal(xlWorksheet, journal);
                allJournals.Add(journal);
            }

            // Close the Workbook.
            xlWorkbook.Close(false);

            // Relase COM Object by decrementing the reference count.
            Marshal.ReleaseComObject(xlWorkbook);

            // Close Excel application.
            xlApp.Quit();

            // Release COM object.
            Marshal.FinalReleaseComObject(xlApp);

            return allJournals;


        }

        //Parse and return new journal
        public static void ParseJournal(Excel.Worksheet worksheet, Journal journal)
        {
            int row = 1;
            while (xlRange.Cells[2, row].Value != null)
            {
                header = new Header(xlRange.Cells[2, row].Text);
                journal.AddHeaderToList(header);
                int col = 3;
                while (xlRange.Cells[col, row].Value != null)
                {
                    headerItem = new HeaderItem(xlRange.Cells[col, row].Text);
                    header.AddItemToList(headerItem);
                    ++col;
                }
                ++row;
            }         
        }
    }
}
