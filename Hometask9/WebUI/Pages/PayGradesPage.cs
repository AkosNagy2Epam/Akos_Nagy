using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Pages
{
    class PayGradesPage 
    {
   
        [FindsBy(How = How.XPath, Using = "//button[@class='oxd-button oxd-button--medium oxd-button--secondary']")]
        public IWebElement Btn_Add { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[@class='oxd-text oxd-text--span']")]
        public IWebElement Txt_Found { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='oxd-button oxd-button--medium oxd-button--label-danger orangehrm-button-margin']")]
        public IWebElement Btn_ConfirmDelete { get; set; }

    }
}
