using GmailTestFramework.Elements;

namespace GmailTestFramework.Pages
{
    public class MailPage
    {
        public static ClickElement CreateNewButton
        {
            get
            {
                return new ClickElement("", "", "//*[@class='aic']/div/div");
            }
        }

        public static TextBox ToTextBox
        {
            get
            {
                return new TextBox("", "", "//textarea[@aria-label='Кому']");
            }
        }

        public static TextBox SubjectTextBox
        {
            get
            {
                return new TextBox("", "subjectbox", "");
            }
        }

        public static TextBox MailBodyTextBox
        {
            get
            {
                return new TextBox("", "", "//*[@class='Am Al editable LW-avf']");
            }
        }

        public static ClickElement SendButton
        {
            get
            {
                return new ClickElement("", "", "//div[contains(@data-tooltip, 'Отправить')]");
            }
        }

        public static ClickElement InboxLink
        {
            get
            {
                return new ClickElement("", "", "//a[contains(@title, 'Входящие')]");
            }
        }

        public static ClickElement LatestLeterCheckBox
        {
            get { return new ClickElement("", "", "//tr[1]//div[@role='checkbox']"); }
        }

        public static ClickElement DeleteButton
        {
            get
            {
                return new ClickElement("", "", "//*[@class='ar9 T-I-J3 J-J5-Ji']");
            }
        }

        public static TextBlock Profile
        {
            get
            {
                return new TextBlock("", "", "//a[contains(@title, 'Аккаунт')]");
            }
        }

        public static TextBlock MailSender
        {
            get
            {
                return new TextBlock("", "", "//div[@class='UI']//table//td[4]/div[1]/span[@email]");
            }
        }

        public static TextBlock MailSubject
        {
            get
            {
                return new TextBlock("", "", "//div[@class='UI']//table//tr[1]/td[6]/div[1]//span/b");
            }
        }

        public static TextBlock Message
        {
            get
            {
                return new TextBlock("", "", "//div[@class='UI']//table//tr[1]/td[6]/div[1]//span[2]");
            }
        }
    }
}
