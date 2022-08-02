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
    public class LanguageChange
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
            MethodFile.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

            Thread.Sleep(3000);
            MethodFile.driver.FindElement(By.XPath("//button[contains(text(), 'US - English')]")).Click();
            Log4Net.log.Info("ClickButton");

        }

        public static void ChooseLanguage()
        {
            MethodFile.driver.FindElement(By.XPath("//a[contains(text(), 'US - Spanish')]")).Click();
            Log4Net.log.Info("ChooseLanguage");
        }

        public static void TakeScreenShot()
        {
            ScreenShotFile.ScreenShot("LanguageChangeScreenShot");
        }
    }
}
