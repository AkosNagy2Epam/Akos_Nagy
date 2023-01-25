using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Pages
{
    class AddPayGradePage
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-input-group oxd-input-field-bottom-space']/div/input")]
        public IWebElement TB_Name { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='oxd-button oxd-button--medium oxd-button--secondary orangehrm-left-space']")]     
        public IWebElement Btn_Save { get; set; }

    }
}
