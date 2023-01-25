using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Pages
{
    abstract class PageBase
    {
        protected readonly IWebDriver Driver;
        
        protected PageBase(IWebDriver driver)
        {
            Driver = driver;
        }
        
    }
}
