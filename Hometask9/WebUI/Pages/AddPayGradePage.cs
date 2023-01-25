using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Pages
{
    class AddPayGradePage
    {        

        [FindsBy(How = How.XPath, Using = "//input[not(@placeholder='Search')]")]
        public IWebElement TB_Name { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[text()=' Save ']")]
        public IWebElement Btn_Save { get; set; }

    }
}
