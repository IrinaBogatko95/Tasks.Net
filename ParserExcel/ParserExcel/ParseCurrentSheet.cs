using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using ParserExcel.LogIn;

namespace ParserExcel
{
    class ParseCurrentSheet
    {           
        public static Header header;
        public static HeaderItem headerItem;

        public static UserName userName;
        public static Password password;
  
        public static Journal journal;
        public static LogInUser logInUser;

        //Parse sheet with journal
        public static Journal ParseOneJournal(Excel.Worksheet worksheet)
        {         
            journal = new Journal(worksheet.Name);
            Excel.Range xlRange = worksheet.UsedRange;
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
            return journal;         
        }

        //Parse excel-sheet with usernames and passwords
        public static List<LogInUser> ParseDataForLogIn(Excel.Worksheet worksheet)
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
    }
}
