using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GmailTestFramework.Actions;
using NUnit.Framework;

namespace GmailTestFramework.TestCases
{
    public class CheckSuccessfulLogin
    {
        [Test]
        public static void CheckSuccessfulLogining()
        {
            PageActions.OpenLoginPage();
            LoginAction.Login();
        }

        [TearDown]
        public static void TearDown()
        {
           TestFramework.TestFramework.TearDown();
        }
    }
}
