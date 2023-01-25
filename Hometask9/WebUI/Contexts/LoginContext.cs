using WebUI.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;

namespace WebUI.Contexts
{
    public class LoginContext : ContextBase
    {
        private readonly LoginPage loginPage;

        public LoginContext(IWebDriver driver) : base(driver)
        {
            loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);

        }

        public static LoginContext Navigate(IWebDriver driver)      //makes sure we will get the LoginContext only after the proper site is loaded
        {            
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");      
            LoginContext loginContext = new LoginContext(driver);
            loginContext.LoadPage();
            return loginContext;
        }

        public StartContext Login(string userName, string pass)
        {
            loginPage.TB_UserName.SendKeys(userName);
            loginPage.TB_Password.SendKeys(pass);
            loginPage.TB_UserName.Submit();
            return new StartContext(Driver);
        }
        public StartContext LoginUsingSiteData()
        {
            //collects login data from the site itself. So if the name and pass changes the login will still work automatically
            string name= loginPage.Txt_UserName.Text.Split(':')[1].Trim();
            string pass= loginPage.Txt_Password.Text.Split(':')[1].Trim();
            return Login(name,pass);
        }

        public override bool LoadPage()
        {
            return Wait.Until(d => loginPage.TB_UserName.Displayed==true);            
        }

        
    }
}
