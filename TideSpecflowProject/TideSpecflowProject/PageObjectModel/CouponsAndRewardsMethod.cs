using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideSpecflowProject.PageObjectModel;
using TideSpecflowProject.Drivers;
using TideSpecflowProject.Utility;

namespace TideSpecflowProject.PageObjectModel
{
    public class CouponsAndRewardsMethod
    {
        public static void NavigateURL()
        {
            MethodFile.driver.Manage().Window.Maximize();
            MethodFile.driver.Navigate().GoToUrl(ExcelFile.excelRead(1, 1));
            Log4Net.log.Info("NavigateURL");
        }

        public static void ClickCouponsAndRewards()
        {
            MethodFile.driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[3]/div/div/div/div[5]/a")).Click();
            Log4Net.log.Info("ClickCouponsAndRewards");
        }

        public static void TakeScreenShot()
        {
            ScreenShotFile.ScreenShot("Coupons and Rewards ScreenShot");
        }
    }
}
