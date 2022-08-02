using OpenQA.Selenium;
using TideSpecflowProject.Drivers;
using TideSpecflowProject.Utility;

namespace TideSpecflowProject.PageObjectModel
{
    public class PnGMethod
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
            MethodFile.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[1]/div/div/div/div[1]/div/a[1]/picture/img")).Click();
            Log4Net.log.Info("ClickButton");
        }

        public static void ExploreTheReport()
        {
            Thread.Sleep(3000);
            MethodFile.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/a")).Click();
            Log4Net.log.Info("ExploreTheReport");
        }

        public static void TakeScreenShot()
        {
            ScreenShotFile.ScreenShot("P&G Results");
        }
    }
}
