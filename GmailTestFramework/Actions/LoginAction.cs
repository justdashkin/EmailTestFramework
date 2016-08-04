using GmailTestFramework.Pages;
using System.Configuration;

namespace GmailTestFramework.Actions
{
    public class LoginAction
    {
        public static void Login()
        {
            LoginPage.EmailTextBox.SetValue(ConfigurationManager.AppSettings["login"]);
            LoginPage.EmailTextBox.Enter();
            LoginPage.PasswordTextBox.SetValue(ConfigurationManager.AppSettings["password"]);
            LoginPage.PasswordTextBox.Enter();
        }
    }
}
