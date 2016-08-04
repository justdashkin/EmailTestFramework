namespace GmailTestFramework.Elements
{
    public class ClickElement : WebElement
    {
        public ClickElement(string Id, string Name, string XPathQuery) : base(Id, Name, XPathQuery)
        {
        }

        public void Click()
        {
            TestFramework.TestFramework.FindWebElement(this).Click();
        }
    }
}
