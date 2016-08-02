using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GmailTestFramework.Pages;

namespace GmailTestFramework.Actions
{
    public class LoginAction
    {
        public static void Login()
        {
            LoginPage.EmailTextBox.SetValue("looksliketestuser@gmail.com");
            LoginPage.EmailTextBox.Enter();
            LoginPage.PasswordTextBox.SetValue("looksliketestuser123");
            LoginPage.PasswordTextBox.Enter();
        }
    }
}
