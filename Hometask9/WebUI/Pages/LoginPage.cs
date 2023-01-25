using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Pages
{
    class LoginPage 
    {

        [FindsBy(How = How.XPath, Using = "//p[1]")]
        public IWebElement Txt_UserName { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[2]")]
        public IWebElement Txt_Password { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@name='username']")]
        public IWebElement TB_UserName { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@name='password']")]
        public IWebElement TB_Password { get; set; }



    }
}
