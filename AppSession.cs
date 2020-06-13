using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewGatherTest 
{
    public class AppSession :MouseHelper
    {
        protected const string DriverUrl = "http://127.0.0.1:4723";
        private const string AppId = @"C:\Users\MSI\Desktop\团队项目 界面测试\oneRichText\bin\Debug\一个.exe";
        private const string AppWorkingDir = @"C:\Users\MSI\Desktop\团队项目 界面测试\oneRichText\bin\Debug";

        protected static WindowsDriver<WindowsElement> session;

        public static void Setup(TestContext context)
        {
            // Launch a new instance of application
            if (session == null)
            {
                // Create a new session to launch application
                var appCapabilities = new DesiredCapabilities();
                appCapabilities.SetCapability("app", AppId);
                appCapabilities.SetCapability("appWorkingDir", AppWorkingDir);
                session = new WindowsDriver<WindowsElement>(new Uri(DriverUrl), appCapabilities);
                Assert.IsNotNull(session);
                Assert.IsNotNull(session.SessionId);

                // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
                session.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1.5));
            }
        }

        public static void TearDown()
        {
            // Close the application and delete the session
            if (session != null)
            {
                session.Close();

                try
                {
                    // confirm to close
                    //session.FindElementByName("Don't Save").Click();
                }
                catch { }

                session.Quit();
                session = null;
            }
        }

        [TestInitialize]
        public void TestInitialize()
        {
            //
        }

        public static void Login()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));

            session.FindElementByAccessibilityId("txtUsername").SendKeys("zyg");
            session.FindElementByAccessibilityId("txtPassword").SendKeys("123");
            session.FindElementByName("Login").Click();

            Thread.Sleep(TimeSpan.FromMilliseconds(100));

            var dialog = session.FindElementByName("Login Success");
            Assert.IsNotNull(dialog);

            session.FindElementByName("确定").Click();
        }

        protected static string SanitizeBackslashes(string input) => input.Replace("\\", Keys.Alt + Keys.NumberPad9 + Keys.NumberPad2 + Keys.Alt);
    }
}
