using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Windows.Forms;

namespace NewGatherTest
{
    [TestClass]
    public class UnitTest1 : AppSession
    {
        
        [TestMethod]
        public void Test_001()//添加分区和知识库
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));

            session.FindElementByName("添加分区").Click();

            Thread.Sleep(TimeSpan.FromMilliseconds(500));

            session.FindElementByName("新分区4").Click();       
            mouse_event(MOUSEEVENTF_MOVE, -30, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            Thread.Sleep(TimeSpan.FromMilliseconds(500));

            session.FindElementByName("添加知识库").Click();

            Thread.Sleep(TimeSpan.FromMilliseconds(200));

            session.FindElementByName("添加知识库").Click();

            Thread.Sleep(TimeSpan.FromMilliseconds(200));
                      
        }
        

        
        [TestMethod]
        public void Test_002()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));

            session.FindElementByName("新分区4").Click();
            mouse_event(MOUSEEVENTF_MOVE, -15, 0, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            Thread.Sleep(TimeSpan.FromSeconds(1));
            MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);


            session.FindElementByName("重命名").Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            //session.FindElementByName("在这里输入").Click();
            session.FindElementByName("请输入目标的名字").Click();

            mouse_event(MOUSEEVENTF_MOVE, 0, 30, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            string key = "{BACKSPACE}";
            SendKeys.SendWait(key);
            SendKeys.SendWait(key);
            SendKeys.SendWait(key);
            SendKeys.SendWait(key);
            SendKeys.SendWait(key);
            Thread.Sleep(TimeSpan.FromSeconds(1));

            key = "123";
            SendKeys.SendWait(key);

            Thread.Sleep(TimeSpan.FromSeconds(2));

            session.FindElementByName("确定").Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            session.FindElementByName("确定").Click();

        }


        [TestMethod]
        public void Test_003()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));

            session.FindElementByName("新分区4").Click();
            mouse_event(MOUSEEVENTF_MOVE, -15, 0, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            Thread.Sleep(TimeSpan.FromSeconds(1));
            MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
           

            session.FindElementByName("重命名").Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            //session.FindElementByName("在这里输入").Click();
            session.FindElementByName("请输入目标的名字").Click();

            mouse_event(MOUSEEVENTF_MOVE, 0, 30, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            string key = "{BACKSPACE}";
            SendKeys.SendWait(key);
            SendKeys.SendWait(key);
            SendKeys.SendWait(key);
            SendKeys.SendWait(key);
            SendKeys.SendWait(key);
            Thread.Sleep(TimeSpan.FromSeconds(1));

            key = "wybnmsl";
            SendKeys.SendWait(key);

            Thread.Sleep(TimeSpan.FromSeconds(2));

            session.FindElementByName("确定").Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));

        }


        [TestMethod]
        public void Test_004()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));

            session.FindElementByName("wybnmsl").Click();
            mouse_event(MOUSEEVENTF_MOVE, -15, 0, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            Thread.Sleep(TimeSpan.FromSeconds(1));
            MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);


            session.FindElementByName("删除").Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            session.FindElementByName("确定").Click();
          
        }
        

        
        [TestMethod]
        public void Test_005()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));

            session.FindElementByName("456").Click();
            mouse_event(MOUSEEVENTF_MOVE, -30, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                
            Thread.Sleep(TimeSpan.FromSeconds(1));

            session.FindElementByName("添加知识库").Click();

        }
        

        [TestMethod]
        public void Test_006()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));

            session.FindElementByName("456").Click();
            mouse_event(MOUSEEVENTF_MOVE, -30, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            Thread.Sleep(TimeSpan.FromSeconds(1));

            session.FindElementByName("安全漏洞").Click();
            mouse_event(MOUSEEVENTF_MOVE, -15, 0, 0, 0);
            MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            Thread.Sleep(TimeSpan.FromSeconds(1));
            MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
            Thread.Sleep(TimeSpan.FromSeconds(1));

            session.FindElementByName("复制").Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            session.FindElementByName("确定").Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            session.FindElementByName("123").Click();
            mouse_event(MOUSEEVENTF_MOVE, -25, 0, 0, 0);
            MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            Thread.Sleep(TimeSpan.FromSeconds(1));
            MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);

            Thread.Sleep(TimeSpan.FromSeconds(1));

            session.FindElementByName("粘贴").Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            session.FindElementByName("安全漏洞").Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        /*
        [TestMethod]
        public void TestMethod2()//选择新的知识库
        {                     
            Thread.Sleep(TimeSpan.FromSeconds(2));
            session.FindElementByName("新知识库0").Click();
            mouse_event(MOUSEEVENTF_MOVE, -15, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }


        
        [TestMethod]
        public void TestMethod3()//为选择的新知识库添加内容
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            //session.FindElementByAccessibilityId("tabControl1").Click();
            //session.FindElementByAccessibilityId("btnBold").Click();
            //session.FindElementByAccessibilityId("rtbInfo").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            var txtItem = session.FindElementByAccessibilityId("rtbInfo");
            txtItem.Clear();
            txtItem.SendKeys("wybnmsl");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            session.FindElementByAccessibilityId("btnSave").Click();
            

        }
        
        */

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }


    }
}
