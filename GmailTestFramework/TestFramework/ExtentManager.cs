using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes;

namespace GmailTestFramework.TestCases
{
    public class ExtentManager
    {
        public static ExtentReports Instance()
        {
            ExtentReports extent;
            string Path = "d:/Users/user/Pictures/Documents/Visual Studio 2015/Projects/GmailTestFramework/ExtentReport.html";
            Console.WriteLine(Path);
            extent = new ExtentReports(Path, false);
            extent.LoadConfig("");
            return extent;
        }
    }
}
