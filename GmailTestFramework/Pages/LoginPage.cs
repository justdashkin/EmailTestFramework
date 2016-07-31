using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using GmailTestFramework.Elements;

namespace GmailTestFramework.Pages
{
    public class LoginPage
    {
        public static WebElement EmailTextBox
        {
            get { return new WebElement("Email", "", ""); }
        }

        public static WebElement PasswordTextBox
        {
            get { return new WebElement("Passwd", "", "");}
        }

        public static WebElement SignInButton
        {
            get { return new WebElement("signIn", "", "");}
        }
    }
}
