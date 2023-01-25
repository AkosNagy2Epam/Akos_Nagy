using WebUI.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Contexts
{
    public class AddPayGradeContext : ContextBase
    {
        AddPayGradePage addPayGradePage;
        public AddPayGradeContext(IWebDriver driver) : base(driver)
        {
            addPayGradePage = new AddPayGradePage(Driver);
            LoadPage();
        }

        public override bool LoadPage()
        {
            return Wait.Until(d => addPayGradePage.TB_Name.Displayed == true);
        }

        public EditPayGradeContext AddNewPayGrade(string name) 
        {
            addPayGradePage.TB_Name.SendKeys(name);
            addPayGradePage.Btn_Save.Click();
            return new EditPayGradeContext(Driver);
        }
    }
}
