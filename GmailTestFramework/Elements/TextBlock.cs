using OpenQA.Selenium;

namespace GmailTestFramework.Elements
{
    public class TextBlock : WebElement
    {
        public TextBlock(string Id, string Name, string XPathQuery) : base(Id, Name, XPathQuery)
        {
        }

        public string Value
        {
            get { return TestFramework.TestFramework.FindWebElement(this).Text; }
        }

        public string EmailAttribute
        {
            get { return TestFramework.TestFramework.FindWebElement(this).GetAttribute("email"); }
        }
    }
}
