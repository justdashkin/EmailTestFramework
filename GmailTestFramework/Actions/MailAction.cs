using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GmailTestFramework.Pages;
using GmailTestFramework.TestFramework;

namespace GmailTestFramework.Actions
{
    public class MailAction
    {
        public static void CreateNewMessage()
        {
            MailPage.CreateNewButton.Click();
            MailPage.ToTextBox.SetValue("looksliketestuser@gmail.com");
            MailPage.SubjectTextBox.SetValue("Looks like test subject");
            MailPage.MailBodyTextBox.SetValue("Looks like awesome test emeil");
            MailPage.SendButton.Click();
            MailPage.InboxLink.Click();
            Thread.Sleep(1000);
            MailPage.InboxLink.Click();
            MailPage.LatestLeterChecBox.Click();
            TestFramework.TestFramework.WaitUntilElementPresent(MailPage.DeleteButton);
            MailPage.DeleteButton.Click();
        }
    }
}
