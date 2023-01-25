using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Pages
{
    class EditPayGradePage : PageBase
    {
        public EditPayGradePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement Btn_CancelEditGrade { get => Driver.FindElement(By.XPath("//div[@class='orangehrm-background-container']//button[text()=' Cancel ']")); }
        public IWebElement Btn_Add { get => Driver.FindElement(By.XPath("//button[text()=' Add ']")); }
        public IWebElement Txt_Found { get => Driver.FindElement(By.XPath("//span[contains(.,'Found')]")); }



        //Add Currency
        public IWebElement Btn_SaveAddCurrency { get => Driver.FindElement(By.XPath("//div[./h6[text()='Add Currency']]//button[text()=' Save ']")); }
        public IWebElement Lb_CurrencyName { get => Driver.FindElement(By.XPath("//div[text()='-- Select --']")); }
        public IWebElement Tb_MinSalary { get => Driver.FindElement(By.XPath("//div[./div/label[text()='Minimum Salary']]//input")); }
        public IWebElement Tb_MaxSalary { get => Driver.FindElement(By.XPath("//div[./div/label[text()='Maximum Salary']]//input")); }



        //Currencies
        public IWebElement Txt_MinRecord { get => Driver.FindElement(By.XPath("//div[./div[text()='Minimum Salary']]/div[@class='data']")); }
        public IWebElement Txt_MaxRecord { get => Driver.FindElement(By.XPath("//div[./div[text()='Maximum Salary']]/div[@class='data']")); }


    }
}
