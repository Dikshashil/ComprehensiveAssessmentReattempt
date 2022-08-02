using OpenQA.Selenium;
using TideSpecflowProject.Drivers;
using TideSpecflowProject.Utility;

namespace TideSpecflowProject.PageObjectModel
{
    public class SearchBarMethod
    {
        public static void NavigateURL()
        {
            MethodFile.driver.Manage().Window.Maximize();
            MethodFile.driver.Navigate().GoToUrl(ExcelFile.excelRead(1, 1));
            Log4Net.log.Info("NavigateURL");
        }

        public static void ClickOnSearchBar()
        {
            Thread.Sleep(3000);
            MethodFile.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

            Thread.Sleep(3000);
            MethodFile.driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[2]/div/div/div/form/div/input")).Click();
            Log4Net.log.Info("ClickOnSearchBar");
        }

        public static void PutValueInSearchBar()
        {
            IWebElement seachBarElement = MethodFile.driver.FindElement(By.XPath("//input[@type='search']"));
            seachBarElement.SendKeys("Powder Detergent");
            seachBarElement.SendKeys(Keys.Enter);
            Log4Net.log.Info("PutValueInSearchBar");
        }

        public static void TakeScreenShot()
        {
            ScreenShotFile.ScreenShot("Result");
        }
    }
}
