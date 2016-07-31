using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GmailTestFramework.TestFramework;
using OpenQA.Selenium;


namespace GmailTestFramework.Elements
{
    public class WebElement
    {
        public string Id;
        public string ClassName;
        public string XPathQuery;

        public WebElement(string Id, string ClassName, string XPathQuery)
        {
            this.Id = Id;
            this.ClassName = ClassName;
            this.XPathQuery = XPathQuery;
        }

        public void Click()
        {
            TestFramework.TestFramework.FindWebElement(this).Click();
        }

        public void SetValue(string Value)
        {
            TestFramework.TestFramework.FindWebElement(this).SendKeys(Value);
            TestFramework.TestFramework.FindWebElement(this).SendKeys(Keys.Enter);
        }
    }
}

