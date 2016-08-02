using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using GmailTestFramework.Elements;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

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

        public static void MaximazeWindow()
        {
            WebDriver.Manage().Window.Maximize();
        }

        public static IWebElement FindWebElement(WebElement webElement)
        {
            if (webElement.Id != "")
                return WebDriver.FindElementById(webElement.Id);

            if (webElement.Name != "")
                return WebDriver.FindElementByName(webElement.Name);

            if (webElement.XPathQuery != "")
                return WebDriver.FindElementByXPath(webElement.XPathQuery);

            return null;
        }

        public static void WaitUntilElementPresent(WebElement element)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath(element.XPathQuery)));
        }

        public static void TearDown()
        {
            WebDriver.Manage().Cookies.DeleteAllCookies();
            WebDriver.Close();
        }
    }
}
