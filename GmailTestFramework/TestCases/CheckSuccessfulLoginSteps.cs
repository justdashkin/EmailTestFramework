using GmailTestFramework.Actions;
using TechTalk.SpecFlow;
using FluentAssertions;
using RelevantCodes.ExtentReports;

namespace GmailTestFramework.TestCases
{
    [Binding]
    public class CheckSuccessfulLoginSteps
    {
        private string mailSubject;
        private string mailBody;
        private static ExtentReports extent = ExtentManager.Instance();
        private static ExtentTest test = extent.StartTest("Check successful login and aproppriate mail", "");

        [Given(@"I open login page")]
        public void GivenIOpenLoginPage()
        {
            PageActions.OpenLoginPage();
            test.Log(LogStatus.Pass, "Login is success!");
        }

        [When(@"I login")]
        public void WhenILogin()
        {
            LoginAction.Login();
            test.Log(LogStatus.Pass, "Mail page is opened");
        }

        [When(@"I create new message")]
        public void WhenICreateNewMessage()
        {
            MailAction.CreateNewMessage();
        }

        [When(@"I address message to ""(.*)""")]
        public void SetTo(string to)
        {
            MailAction.SetTo(to);
        }

        [When(@"I print subject ""(.*)""")]
        public void SetSubject(string subject)
        {
            mailSubject = subject;
            MailAction.SetSubject(subject);
        }

        [When(@"I print message: ""(.*)""")]
        public void SetMailBody(string usersMailBody)
        {
            mailBody = usersMailBody;
            MailAction.SetMailBody(usersMailBody);
        }

        [When(@"I send mail")]
        public void SendMail()
        {
            MailAction.SendMessage();
            test.Log(LogStatus.Pass, "Email was sended");
        }

        [When(@"I find message")]
        public void Lala()
        {
            MailAction.WaitMessage();
            test.Log(LogStatus.Pass, "Email was founded");
        }

        [Then(@"My profile should be opened")]
        public void CheckSuccessfulLogin()
        {
            MailAction.IsUserProfile.Should().BeTrue();
            test.Log(LogStatus.Pass, "Login was succed and verified");
        }

        [Then(@"Sender is expected sender")]
        public void CheckSender()
        {
            MailAction.IsExpectedSender.Should().BeTrue();
            test.Log(LogStatus.Pass, "Sender is expected sender");
        }

        [Then(@"Subject is expected subject")]
        public void CheckSubject()
        {
            MailAction.IsExpectedSubject(mailSubject).Should().BeTrue();
            test.Log(LogStatus.Pass, "Subject is expected subject");
        }

        [Then(@"Message is expected message")]
        public void CheckMessage()
        {
            MailAction.IsExpectedMessage(mailBody).Should().BeTrue();
            test.Log(LogStatus.Pass, "Message is expected message. Test passed!");
        }
        
        [AfterScenario]
        public void TearDown()
        {
            MailAction.DeleteMessage();
            extent.EndTest(test);
            extent.Flush();
            extent.Close();
            TestFramework.TestFramework.TearDown();
        }
    }
}
