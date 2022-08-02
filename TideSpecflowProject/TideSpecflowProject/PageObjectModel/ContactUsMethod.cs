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
    public class ContactUsMethod
    {
        public static void NavigateURL()
        {
            MethodFile.driver.Manage().Window.Maximize();
            MethodFile.driver.Navigate().GoToUrl(ExcelFile.excelRead(1, 1));
            Log4Net.log.Info("NavigateURL");
        }
        public static void ClickButton()
        {
            Thread.Sleep(3000);
            MethodFile.driver.FindElement(By.XPath("/html/body/div[6]/div/a")).Click();

            Thread.Sleep(3000);
            MethodFile.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[1]/div/div/div/div[2]/a[2]")).Click();
            Log4Net.log.Info("ClickButton");

        }
        public static void TakeScreenShot()
        {
            ScreenShotFile.ScreenShot("Contact Us Screenshot");
        }

    }
}
