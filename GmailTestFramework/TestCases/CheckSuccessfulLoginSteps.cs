using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GmailTestFramework.Actions;
using NUnit.Framework;
using TechTalk.SpecFlow;
using FluentAssertions;
using RelevantCodes.ExtentReports;


namespace GmailTestFramework.TestCases
{
   //[Binding]
    public class CheckSuccessfulLoginSteps
    {
        private ExtentReports extent;
        private ExtentTest test;

      /*  [Given(@"I open login page")]
        public void GivenIOpenLoginPage()
        {
            test = extent.StartTest("Login page", "Verify Logining");
            PageActions.OpenLoginPage();
            test.Log(LogStatus.Pass, "good job, girl!");
        }

        [When(@"I login")]
        public void WhenILogin()
        {
            LoginAction.Login();
        }

        [When(@"I create new message")]
        public void WhenICreateNewMessage()
        {
            MailAction.CreateNewMessage();
        }

        [AfterScenario]
        public void TearDown()
        {
            extent.EndTest(test);
            extent.Flush();
            extent.Close();
            TestFramework.TestFramework.TearDown();
        }*/
        
        [Test]
        public void CheckSuccessfulLogining()
        {
            extent = ExtentManager.Instance();
            test = extent.StartTest("verify", "sss");
            extent.StartTest("Login page", "Verify Logining");
            test.Log(LogStatus.Pass, "good job, girl!");
            PageActions.OpenLoginPage();
            LoginAction.Login();
            MailAction.CreateNewMessage();
        }
        
       [TearDown]
        public void TearDown()
        {
            extent.EndTest(test);
            extent.Flush();
            extent.Close();
            TestFramework.TestFramework.TearDown();
        }
        
    }
}
