using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideSpecflowProject.Drivers;

namespace TideSpecflowProject.Utility
{
    public class ScreenShotFile
    {
        public static void ScreenShot(string screenShotName)
        {
            ((ITakesScreenshot)MethodFile.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may168\Desktop\Comprehensive\TideSpecflowProject\ScreenShot\" + screenShotName + ".Png");
        }
    }
}
