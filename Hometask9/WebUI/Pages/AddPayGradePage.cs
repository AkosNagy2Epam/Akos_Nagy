using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Pages
{
    class AddPayGradePage : PageBase
    {        
        public AddPayGradePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement TB_Name { get => Driver.FindElement(By.XPath("//input[not(@placeholder='Search')]")); }
        public IWebElement Btn_Save { get => Driver.FindElement(By.XPath("//button[text()=' Save ']")); }

    }
}
