using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Pages
{
    class EditPayGradePage
    {
 
        [FindsBy(How = How.XPath, Using = "//div[@class='orangehrm-background-container']//button[text()=' Cancel ']")]
        public IWebElement Btn_CancelEditGrade { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[text()=' Add ']")]
        public IWebElement Btn_Add { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Found')]")]
        public IWebElement Txt_Found { get; set; }



        //Add Currency
        [FindsBy(How = How.XPath, Using = "//div[./h6[text()='Add Currency']]//button[text()=' Save ']")]
        public IWebElement Btn_SaveAddCurrency { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[text()='-- Select --']")]
        public IWebElement Lb_CurrencyName { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[./div/label[text()='Minimum Salary']]//input")]
        public IWebElement Tb_MinSalary { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[./div/label[text()='Maximum Salary']]//input")]
        public IWebElement Tb_MaxSalary { get; set; }



        //Currencies
        [FindsBy(How = How.XPath, Using = "//div[./div[text()='Minimum Salary']]/div[@class='data']")]
        public IWebElement Txt_MinRecord { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[./div[text()='Maximum Salary']]/div[@class='data']")]
        public IWebElement Txt_MaxRecord { get; set; }


    }
}
