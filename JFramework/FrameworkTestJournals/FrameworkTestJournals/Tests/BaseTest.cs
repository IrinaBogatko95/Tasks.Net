using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkTestJournals.Tests
{
   public class BaseTest
    {
        public static void ChooseBrowser(string nameBrowser)
        {
            WebDriver.SetDriver(nameBrowser);
        }
    }
}
