using OpenQA.Selenium;
using TideSpecflowProject.Drivers;
using TideSpecflowProject.Utility;

namespace TideSpecflowProject.PageObjectModel
{
    public class ShopProducts
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

            MethodFile.driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[3]/div/div/div/div[1]/a")).Click();
            Log4Net.log.Info("ClickButton");
        }

        public static void SelectProduct()
        {
            Thread.Sleep(3000);
            MethodFile.driver.FindElement(By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[4]/div/div/div/div[1]/div/div[1]/a/picture/img")).Click();
            Log4Net.log.Info("SelectProduct");
        }

        public static void TakeScreenShot()
        {
            ScreenShotFile.ScreenShot("Retailer Product");
        }
    }
}
