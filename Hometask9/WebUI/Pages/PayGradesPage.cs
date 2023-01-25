using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Pages
{
    class PayGradesPage : PageBase
    {
        
        public PayGradesPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement Btn_Add { get => Driver.FindElement(By.XPath("//button[@class='oxd-button oxd-button--medium oxd-button--secondary']")); }
        public IWebElement Txt_Found { get => Driver.FindElement(By.XPath("//span[contains(.,'Found')]")); }
        public IWebElement Btn_ConfirmDelete { get => Driver.FindElement(By.XPath("//button[text()=' Yes, Delete ']")); }
        
    }
}
