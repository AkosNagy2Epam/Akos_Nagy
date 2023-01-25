using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Pages
{
    class EditPayGradePage
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='orangehrm-background-container']/div[@class='orangehrm-card-container']//button[1]")]
        public IWebElement Btn_CancelEditGrade { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='oxd-button oxd-button--medium oxd-button--secondary']")]
        public IWebElement Btn_Add { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[@class='oxd-text oxd-text--span']")]
        public IWebElement Txt_Found { get; set; }



        //Add Currency
        [FindsBy(How = How.XPath, Using = "//form[./div/div/div/div/div/div[@class='oxd-select-wrapper']]//button[2]")]
        public IWebElement Btn_SaveAddCurrency { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-select-text-input']")]
        public IWebElement Lb_CurrencyName { get; set; }
        [FindsBy(How = How.XPath, Using = "//form/div[2][@class='oxd-form-row']/div/div[1]//input")]
        public IWebElement Tb_MinSalary { get; set; }
        [FindsBy(How = How.XPath, Using = "//form/div[2][@class='oxd-form-row']/div/div[2]//input")]
        public IWebElement Tb_MaxSalary { get; set; }



        //Currencies
        [FindsBy(How = How.XPath, Using = "//div[@class='card-item card-body-slot']/div[1]/div/div[@class='data']")]
        public IWebElement Txt_MinRecord { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='card-item card-body-slot']/div[2]/div/div[@class='data']")]
        public IWebElement Txt_MaxRecord { get; set; }


    }
}
