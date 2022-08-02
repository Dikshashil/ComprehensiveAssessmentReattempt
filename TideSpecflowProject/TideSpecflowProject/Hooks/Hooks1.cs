using TideSpecflowProject.Drivers;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TideSpecflowProject.Utility;
using AventStack.ExtentReports.Model;

namespace TideSpecflowProject.Hooks
{
    [Binding]
    public class Hooks1 
    { 
     public static IWebDriver driver;

        [BeforeTestRun]
        public static void GenerateReport()
        {
            ExtentReportFile.generateReport();

        }
        [AfterTestRun]
        public static void closeExtentReport()
        {
            ExtentReportFile.flushReport();

        }
        [BeforeFeature]
        public static void featureBrowser(FeatureContext featureContext)
        {
            ExtentReportFile.featurefile();
            Log4Net.log.Info("FeatureWebsites");
        }

        [BeforeScenario]
        public static void InitializeDriver(ScenarioContext scenarioContext)
        {

            MethodFile.InitializeDriver();
            ExtentReportFile.scenarioflie();
            Log4Net.log.Info("FeatureWebsites");
        }

        [AfterStep]
        public static void InsertReportingSteps(ScenarioContext scenarioContext)
        {
            ExtentReportFile.scenariosteps();
        }

        [AfterScenario]
        public static void CloseDriver()
        {
            MethodFile.driver.Close();
        }

    }
}