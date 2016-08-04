using RelevantCodes.ExtentReports;
using System;

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
