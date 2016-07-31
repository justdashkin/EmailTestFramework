using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using GmailTestFramework.Elements;

namespace GmailTestFramework.TestFramework
{
    public class TestFramework
    {
        public static RemoteWebDriver _WebDriver;

        public static RemoteWebDriver WebDriver
        {
            get
            {
                if (_WebDriver == null)
                    _WebDriver = new ChromeDriver();

                return _WebDriver;
            }
        }

        public static void OpenURL(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        public static IWebElement FindWebElement(WebElement webElement)
        {
            if (webElement.Id != "")
                return WebDriver.FindElementById(webElement.Id);

            if (webElement.ClassName != "")
                return WebDriver.FindElementByClassName(webElement.ClassName);

            if (webElement.XPathQuery != "")
                return WebDriver.FindElementByXPath(webElement.XPathQuery);

            return null;
        }

        public static void TearDown()
        {
            WebDriver.Manage().Cookies.DeleteAllCookies();
            WebDriver.Close();
        }
    }
}
