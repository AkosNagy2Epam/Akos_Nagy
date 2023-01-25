using WebUI.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;

namespace WebUI.Contexts
{
    public class AdminContext : ContextBase
    {
        AdminPage adminPage;
       
        public AdminContext(IWebDriver driver) : base(driver)
        {
            adminPage = new AdminPage();
            PageFactory.InitElements(driver,adminPage); 
            LoadPage();
        }

        

        

        public override bool LoadPage()
        {
            return Wait.Until(d => adminPage.Btn_Job.Displayed == true);
        }

        public PayGradesContext GoToPayGradesPage()
        {
            adminPage.Btn_Job.Click();
            Wait.Until(d => adminPage.Btn_PayGrades.Displayed == true);
            adminPage.Btn_PayGrades.Click();
            return new PayGradesContext(Driver);
        }
        
    }
}
