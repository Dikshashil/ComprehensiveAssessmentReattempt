using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideSpecflowProject.Drivers;
using TideSpecflowProject.Utility;

namespace TideSpecflowProject.PageObjectModel
{
    public class LiveChatMethod
    {
        public static void NavigateURL()
        {
            MethodFile.driver.Manage().Window.Maximize();
            MethodFile.driver.Navigate().GoToUrl(ExcelFile.excelRead(1, 1));
            Log4Net.log.Info("NavigateURL");
        }

        public static void ClickOnLiveChat()
        {
            Thread.Sleep(3000);
            MethodFile.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

            Thread.Sleep(3000);
            MethodFile.driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[1]/div/div/div/div[2]/a[1]")).Click();
            Log4Net.log.Info("ClickOnLiveChat");
        }

        public static void ScrollToElement()
        {
            MethodFile.driver.FindElement(By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[3]/div/div/div")).Click();
            Log4Net.log.Info("ScrollToElement");
        }

        public static void TakeScreenShot()
        {
            ScreenShotFile.ScreenShot("Result");
        }
    }
}
