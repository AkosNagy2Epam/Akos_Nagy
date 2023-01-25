using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Pages
{
    class StartPage : PageBase
    {        
        public StartPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement Btn_Admin { get => Driver.FindElement(By.XPath("//*[@href='/web/index.php/admin/viewAdminModule']")); }

       
    }
}
