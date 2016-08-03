﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GmailTestFramework.TestFramework;

namespace GmailTestFramework.Actions
{
    public class PageActions
    {
        public static void OpenLoginPage()
        {
            TestFramework.TestFramework.MaximazeWindow();
            TestFramework.TestFramework.OpenURL(ConfigurationManager.AppSettings["baseUrl"]);
        }
    }
}
