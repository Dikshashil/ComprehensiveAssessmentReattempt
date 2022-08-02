using OpenQA.Selenium;
using TideSpecflowProject.Drivers;
using TideSpecflowProject.Utility;

namespace TideSpecflowProject.PageObjectModel
{
    public class WhatsNewMethod
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
            MethodFile.driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[3]/div/div/div/div[4]/a")).Click();
            Log4Net.log.Info("ClickButton");
        }

        public static void TakeScreenShot()
        {
            ScreenShotFile.ScreenShot("What'sNew LatestArticles");
        }
    }
}
