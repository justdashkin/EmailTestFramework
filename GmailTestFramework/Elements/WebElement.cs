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
        public string Name;
        public string XPathQuery;

        public WebElement(string Id, string Name, string XPathQuery)
        {
            this.Id = Id;
            this.Name = Name;
            this.XPathQuery = XPathQuery;
        }

        public void Click()
        {
            TestFramework.TestFramework.FindWebElement(this).Click();
        }

        public void SetValue(string Value)
        {
            TestFramework.TestFramework.FindWebElement(this).SendKeys(Value);
        }

        public void Enter()
        {
            TestFramework.TestFramework.FindWebElement(this).SendKeys(Keys.Enter);
        }
    }
}

