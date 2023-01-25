using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using WebUI.Contexts;
using WebUI.Entities;

namespace WebUITests.Steps
{
    [Binding]
    public class SalaryGradeSteps
    {
        ScenarioContext scenarioContext;
        StartContext startContext;
        PayGradesContext payGradesContext;
        EditPayGradeContext editPayGradeContext;
        private string testName="TestGrade";
        private int testMinSalary = 1000;
        private int testMaxSalary = 3000;


        public SalaryGradeSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            scenarioContext.Add("testName", testName);
        }

        [Given(@"I am logged in to the site")]
        public void GivenIAmLoggedInToTheSite()
        {
            startContext = LoginContext.Navigate(scenarioContext.Get<IWebDriver>("Driver")).LoginUsingSiteData();
        }
        
        [Given(@"I registered a new pay grade name")]
        public void GivenIRegisteredANewPayGradeName()
        {
            payGradesContext=startContext.GoToAdminPage().GoToPayGradesPage();
            payGradesContext.DeleteGradeIfExists(testName);
            editPayGradeContext=payGradesContext.GoToAddPayGradePage().AddNewPayGrade(testName);

        }
        
        [Given(@"I am on the Edit Pay Grades page with entered data for a new salary grade")]
        public void GivenIAmOnTheEditPayGradesPageWithEnteredDataForANewSalaryGrade()
        {
            editPayGradeContext.EnterNewSalaryData(EditPayGradeContext.CurrencyNames.HUF, testMinSalary, testMaxSalary);
        }
        
        [When(@"I click on the save salary grade button")]
        public void WhenIClickOnTheSaveSalaryGradeButton()
        {
            editPayGradeContext.SaveNewSalary();
        }
        
        [When(@"I click on the cancel pay grade button")]
        public void WhenIClickOnTheCancelPayGradeButton()
        {
            payGradesContext = editPayGradeContext.CancelBackToPayGradesPage();            
        }
        
        [Then(@"the entered minimum and maximum salary should be saved and displayed")]
        public void ThenTheEnteredMinimumAndMaximumSalaryShouldBeSavedAndDisplayed()
        {
            SalaryGradeData result = editPayGradeContext.GetSingleSalaryGrade();
            Assert.AreEqual(testMinSalary, result.MinSalary);
            Assert.AreEqual(testMaxSalary, result.MaxSalary);
        }
        
        [Then(@"I shouldn't see the entered salary data on the Pay Grades page")]
        public void ThenIShouldnTSeeTheEnteredSalaryDataOnThePayGradesPage()
        {
            Assert.IsFalse( payGradesContext.DoesNameHaveCurrencyRecord(testName));            
        }
    }
}
