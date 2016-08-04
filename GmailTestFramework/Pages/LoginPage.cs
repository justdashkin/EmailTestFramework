using GmailTestFramework.Elements;

namespace GmailTestFramework.Pages
{
    public class LoginPage
    {
        public static TextBox EmailTextBox
        {
            get { return new TextBox("Email", "", ""); }
        }

        public static TextBox PasswordTextBox
        {
            get { return new TextBox("Passwd", "", "");}
        }

        public static ClickElement SignInButton
        {
            get { return new ClickElement("signIn", "", "");}
        }
    }
}
