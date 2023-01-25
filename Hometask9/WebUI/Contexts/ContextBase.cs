using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Contexts
{
    public abstract class ContextBase
    {
        protected readonly IWebDriver Driver;
        protected readonly WebDriverWait Wait;
        protected ContextBase(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 20));
        }

        abstract public bool LoadPage();
                    

            
        
    }
}
