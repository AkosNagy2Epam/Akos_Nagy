﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace WebUITests.Hooks
{
    [Binding]
    public sealed class Hooks_Reporting
    {
        static ExtentReports extent;
        static ExtentTest scenarioName;
        static ExtentTest featureName;

        [BeforeScenario]
        public void StartDriver()
        {
            scenarioName = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

       

        [BeforeFeature]
        public static void BeforeFeature()
        {
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }
        [AfterStep]
        public static void InsertReportingSteps()
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();



            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenarioName.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenarioName.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenarioName.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenarioName.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else
            {
                if (stepType == "Given")
                    scenarioName.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "And")
                    scenarioName.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "When")
                    scenarioName.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "Then")
                    scenarioName.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
            }

        }

        [BeforeTestRun]
        public static void Initialize()
        {
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(@"TestReport\");
            htmlReporter.Config.Theme = Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

        }

        [AfterTestRun]
        public static void TearDown()
        {
            extent.Flush();
        }
    }
}
