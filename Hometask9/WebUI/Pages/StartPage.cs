using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Pages
{
    class StartPage
    {        

        [FindsBy(How = How.XPath, Using = "//*[@href='/web/index.php/admin/viewAdminModule']")]
        public IWebElement Btn_Admin { get; set; }

       
    }
}
