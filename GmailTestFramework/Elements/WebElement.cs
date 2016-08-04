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

        public string Title
        {
            get { return TestFramework.TestFramework.FindWebElement(this).GetAttribute("title"); }
        }
    }
}

