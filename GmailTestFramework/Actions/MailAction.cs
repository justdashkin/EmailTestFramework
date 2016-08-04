using System;
using System.Configuration;
using System.Threading;
using GmailTestFramework.Pages;
using FluentAssertions;

namespace GmailTestFramework.Actions
{
    public class MailAction
    {
        public static bool IsUserProfile
        {
            get { return MailPage.Profile.Title.Contains(ConfigurationManager.AppSettings["login"]); }
        }

        public static bool IsExpectedSender
        {
            get { return (MailPage.MailSender.EmailAttribute == ConfigurationManager.AppSettings["login"]); }
        }

        public static bool IsExpectedSubject(string subject)
        {
            return (MailPage.MailSubject.Value == subject);
        }

        public static bool IsExpectedMessage(string mailBody)
        {
            return (MailPage.Message.Value.Contains(mailBody));
        }

        public static void CreateNewMessage()
        {
            MailPage.CreateNewButton.Click();
        }

        public static void SetTo(string to)
        {
            MailPage.ToTextBox.SetValue(to);
        }

        public static void SetSubject(string subject)
        {
            MailPage.SubjectTextBox.SetValue(subject);
        }

        public static void SetMailBody(string mailBody)
        {
            MailPage.MailBodyTextBox.SetValue(mailBody);
        }

        public static void SendMessage()
        {
            MailPage.SendButton.Click();
        }

        public static void RefreshPage()
        {
            TestFramework.TestFramework.RefreshPage();
        }

        public static void WaitMessage()
        {
            TestFramework.TestFramework.RefreshPage();
            MailPage.InboxLink.Click();
        }

        public static void DeleteMessage()
        {
            MailPage.LatestLeterCheckBox.Click();
            TestFramework.TestFramework.WaitUntilElementPresent(MailPage.DeleteButton);
            MailPage.DeleteButton.Click();
        }
    }
}
