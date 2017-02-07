using System;
using System.Collections.Generic;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;
using ParserExcel.LogIn;
using ParserExcel.Search;

namespace ParserExcel
{
    public static class ParseExcel
    {
        public static Excel.Worksheet xlWorksheet;

        //Parse excel-file with journals ans returns list with all parsed journals
        public static List<Journal> ParserForJournal(string path)
        {
            List<Journal> allJournals = new List<Journal>();

            Excel.Workbook xlWorkbook = ExcelBook.OpenWorkbook(path);

            for (int i = 1; i <= xlWorkbook.Sheets.Count; i++)
            {
                xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(i);
                Journal journal = ParseCurrentSheet.ParseOneJournal(xlWorksheet);
                allJournals.Add(journal);
            }
            ExcelBook.CloseWorkbook(xlWorkbook);

            return allJournals;
        }

        //Parse excel-file with usernames and passwords
        public static List<LogInUser> ParserForLogIn(string path)
        {
            Excel.Workbook xlWorkbook = ExcelBook.OpenWorkbook(path);

            xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(1);
            List<LogInUser> allUsers = ParseCurrentSheet.ParseDataTwoColumns(xlWorksheet);

            ExcelBook.CloseWorkbook(xlWorkbook);

            return allUsers;
        }
       
        //Parse excel-file with searches
        public static List<SimpleSearch> ParserForSimpleSearch(string path)
        {
            Excel.Workbook xlWorkbook = ExcelBook.OpenWorkbook(path);

            xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(1);
            List<SimpleSearch> allSearches = ParseCurrentSheet.ParseDataOneColumn(xlWorksheet);

            ExcelBook.CloseWorkbook(xlWorkbook);

            return allSearches;
        }
    }
}
