using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideSpecflowProject.Utility;

namespace TideSpecflowProject.Drivers
{
    public class MethodFile
    {
        public static IWebDriver driver;
        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
            Log4Net.log.Info("IntializeDriver");

        }
        public static void CloseDriver()
        {
            driver.Close();
            Log4Net.log.Info("CloseDriver");
        }
    }
}
