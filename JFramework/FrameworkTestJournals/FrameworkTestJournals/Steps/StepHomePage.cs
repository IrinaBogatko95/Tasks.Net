using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkTestJournals.Steps
{
    class StepHomePage
    {
        public void OpenHomePage()
        {
            var homePage = new HomePage("chrome");
            homePage.NavigateHere();
        }
    }
}
