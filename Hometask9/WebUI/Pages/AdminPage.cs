using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Pages
{
    class AdminPage
    {

        [FindsBy(How = How.XPath, Using = "//nav[@aria-label='Topbar Menu']/ul/li[2]")]
        public IWebElement Btn_Job { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[text()='Pay Grades']")]
        public IWebElement Btn_PayGrades { get; set; }


    }
}
