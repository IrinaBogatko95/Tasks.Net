using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace ParserExcel
{
    //Class contains operations with excel-workbook
    class ExcelBook
    {
        public static Excel.Application xlApp;

        //Opens workbook
        public static Excel.Workbook OpenWorkbook(string path)
        {
            // Reference to Excel Application.
            xlApp = new Excel.Application();

            return xlApp.Workbooks.Open(Path.GetFullPath(path));
        }

        //Close workbook
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
