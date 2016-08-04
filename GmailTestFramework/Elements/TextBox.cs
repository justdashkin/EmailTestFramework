using OpenQA.Selenium;

namespace GmailTestFramework.Elements
{
    public class TextBox : WebElement
    {
        public TextBox(string Id, string Name, string XPathQuery) : base(Id, Name, XPathQuery)
        {
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
