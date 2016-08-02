using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using GmailTestFramework.Elements;

namespace GmailTestFramework.Pages
{
    public class MailPage
    {
        public static WebElement CreateNewButton
        {
            get
            {
                return new WebElement("", "", "//*[@class='aic']/div/div");
            }
        }

        public static WebElement ToTextBox
        {
            get
            {
                return new WebElement("", "", "//textarea[@aria-label='Кому']");
            }
        }

        public static WebElement SubjectTextBox
        {
            get
            {
                return new WebElement("", "subjectbox", "");
            }
        }

        public static WebElement MailBodyTextBox
        {
            get
            {
                return new WebElement("", "", "//*[@class='Am Al editable LW-avf']");
            }
        }

        public static WebElement SendButton
        {
            get
            {
                return new WebElement("", "", "//div[contains(@data-tooltip, 'Отправить')]");
            }
        }

        public static WebElement InboxLink
        {
            get
            {
                return new WebElement("", "", "//a[contains(@title, 'Входящие')]");
            }
        }

        public static WebElement LatestLeterChecBox
        {
            get { return new WebElement("", "", "//tr[1]//div[@role='checkbox']"); }
        }

        public static WebElement DeleteButton
        {
            get
            {
                return new WebElement("", "", "//*[@class='ar9 T-I-J3 J-J5-Ji']");
            }
        }
    }
}
