using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using WebUI.Contexts;

namespace WebUITests.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private IWebDriver driver;
        private readonly ScenarioContext scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {            
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void StartDriver()
        {            
            driver = new ChromeDriver();
            driver.Manage().Window.Size = new System.Drawing.Size(1000, 1000);
            scenarioContext.Add("Driver", driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (driver.Url.Contains("payGrade"))
            {
                new EditPayGradeContext(driver).CancelBackToPayGradesPage();
            }

            new PayGradesContext(driver).DeleteGradeIfExists(scenarioContext.Get<string>("testName"));

            driver.Quit();
        }
     
    }
}
