﻿using WebUI.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Contexts
{
    public class StartContext : ContextBase
    {
        StartPage startPage;

        public StartContext(IWebDriver driver) : base(driver)
        {
            startPage = new StartPage(driver);
            LoadPage();
        }

        public override bool LoadPage()
        {
            return Wait.Until(d => startPage.Btn_Admin.Displayed == true);            
        }
        

        public AdminContext GoToAdminPage() 
        {
            startPage.Btn_Admin.Click();
            return new AdminContext(Driver);
        }

        
    }
}
