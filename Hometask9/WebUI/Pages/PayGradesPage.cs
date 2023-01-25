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
        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Found')]")]
        public IWebElement Txt_Found { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[text()=' Yes, Delete ']")]
        public IWebElement Btn_ConfirmDelete { get; set; }

    }
}
