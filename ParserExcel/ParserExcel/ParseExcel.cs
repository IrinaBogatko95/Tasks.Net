using System;
using System.Collections.Generic;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;
using ParserExcel.LogIn;

namespace ParserExcel
{
    public static class ParseExcel
    {
        public static Excel.Worksheet xlWorksheet;
        public static Excel.Application xlApp;

        //Parse excel-file with journals ans returns list with all parsed journals
        public static List<Journal> ParserForJournal(string path)
        {
            List<Journal> allJournals = new List<Journal>();

            Excel.Workbook xlWorkbook = OpenWorkbook(path);

            for (int i = 1; i <= xlWorkbook.Sheets.Count; i++)
            {
                xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(i);
                Journal journal = ParseCurrentSheet.ParseOneJournal(xlWorksheet);
                allJournals.Add(journal);
            }
            CloseWorkbook(xlWorkbook);

            return allJournals;
        }

        //Parse excel-file with usernames and passwords
        public static List<LogInUser> ParserForLogIn(string path)
        {
            Excel.Workbook xlWorkbook = OpenWorkbook(path);

            xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(1);
            List<LogInUser> allUsers = ParseCurrentSheet.ParseDataForLogIn(xlWorksheet);
              
            CloseWorkbook(xlWorkbook);

            return allUsers;
        }


        public static Excel.Workbook OpenWorkbook(string path)
        {
            // Reference to Excel Application.
            xlApp = new Excel.Application();

            return xlApp.Workbooks.Open(Path.GetFullPath(path));
        }


        public static void CloseWorkbook(Excel.Workbook xlWorkbook)
        {
            xlWorkbook.Close(false);

            // Relase COM Object by decrementing the reference count.
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();

            // Release COM object.
            Marshal.FinalReleaseComObject(xlApp);
        }
    }
}
