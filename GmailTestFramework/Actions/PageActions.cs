using System.Configuration;

namespace GmailTestFramework.Actions
{
    public class PageActions
    {
        public static void OpenLoginPage()
        {
            TestFramework.TestFramework.MaximazeWindow();
            TestFramework.TestFramework.OpenURL(ConfigurationManager.AppSettings["baseUrl"]);
        }
    }
}
