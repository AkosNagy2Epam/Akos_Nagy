using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Pages
{
    class AdminPage : PageBase
    {

        

        
        public AdminPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement Btn_Job { get => Driver.FindElement(By.XPath("//nav[@aria-label='Topbar Menu']/ul/li[2]")); }
        public IWebElement Btn_PayGrades { get => Driver.FindElement(By.LinkText("Pay Grades")); }


    }
}
