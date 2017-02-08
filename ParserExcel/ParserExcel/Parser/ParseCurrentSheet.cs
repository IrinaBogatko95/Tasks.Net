using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using ParserExcel.LogIn;
using ParserExcel.Search;

namespace ParserExcel
{
    //Parsers for one sheet in excel
    class ParseCurrentSheet
    {           
        //Parse sheet with journal
        public static Journal ParseOneJournal(Excel.Worksheet worksheet)
        {
            Journal journal = new Journal(worksheet.Name);
            Excel.Range xlRange = worksheet.UsedRange;
            int row = 1;
            while (xlRange.Cells[2, row].Value != null)
            {
                Header header = new Header(xlRange.Cells[2, row].Text);
                journal.AddHeaderToList(header);
                int col = 3;
                while (xlRange.Cells[col, row].Value != null)
                {
                    HeaderItem headerItem = new HeaderItem(xlRange.Cells[col, row].Text);
                    header.AddItemToList(headerItem);
                    ++col;
                }
                ++row;
            }
            return journal;         
        }

        //Parse excel-sheet with data in two columns
        public static List<LogInUser> ParseDataTwoColumns(Excel.Worksheet worksheet)
        {
            List<LogInUser> allUsers = new List<LogInUser>();
            Excel.Range xlRange = worksheet.UsedRange;
            int row = 1;                       
               while (xlRange.Cells[row, 1].Value != null && xlRange.Cells[row, 2].Value != null)
                {
                allUsers.Add(new LogInUser(xlRange.Cells[row, 1].Text, xlRange.Cells[row, 2].Text));           
                ++row;
                }
            return allUsers;
        }

        //Parse excel-sheet with data in one column
        public static List<SimpleSearch> ParseDataOneColumn(Excel.Worksheet worksheet)
        {
            List<SimpleSearch> allSearches = new List<SimpleSearch>();
            Excel.Range xlRange = worksheet.UsedRange;

            int row = 1;
            while (xlRange.Cells[row, 1].Value != null)
            {
                allSearches.Add(new SimpleSearch(xlRange.Cells[row, 1].Text));
                ++row;
            }
            return allSearches;
        }
    }
}
