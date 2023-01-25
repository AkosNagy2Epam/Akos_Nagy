using WebUI.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Contexts
{
    public class AdminContext : ContextBase
    {
        AdminPage adminPage;
       
        public AdminContext(IWebDriver driver) : base(driver)
        {
            adminPage = new AdminPage(driver);
            LoadPage();
        }

        

        

        public override bool LoadPage()
        {
            return Wait.Until(d => adminPage.Btn_Job.Displayed == true);
        }

        public PayGradesContext GoToPayGradesPage()
        {
            adminPage.Btn_Job.Click();
            Wait.Until(d => adminPage.Btn_PayGrades);
            adminPage.Btn_PayGrades.Click();
            return new PayGradesContext(Driver);
        }
        
    }
}
