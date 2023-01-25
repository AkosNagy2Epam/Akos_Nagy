using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Pages
{
    class LoginPage : PageBase
    {
        
        public LoginPage(IWebDriver driver) : base(driver)
        {           
        }

       
        public IWebElement Txt_UserName { get => Driver.FindElement(By.XPath("//p[1]")); }
        public IWebElement Txt_Password { get => Driver.FindElement(By.XPath("//p[2]")); }
        public IWebElement TB_UserName { get => Driver.FindElement(By.XPath("//*[@name='username']")); }
        public IWebElement TB_Password { get => Driver.FindElement(By.XPath("//*[@name='password']")); }



    }
}
