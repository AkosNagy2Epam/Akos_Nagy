using WebUI.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SeleniumExtras.PageObjects;

namespace WebUI.Contexts
{
    public class PayGradesContext : ContextBase
    {
        PayGradesPage payGradesPage;
        public PayGradesContext(IWebDriver driver) : base(driver)
        {
            payGradesPage = new PayGradesPage();
            PageFactory.InitElements(driver, payGradesPage);
            LoadPage();
        }

        
        public override bool LoadPage()
        {
            return Wait.Until(d => payGradesPage.Txt_Found.Displayed == true);
        }

        public void DeleteGradeIfExists(string name) 
        {
            ReadOnlyCollection<IWebElement> btn_Del;
            btn_Del = Driver.FindElements(By.XPath($"//div[./div/div/div/div[contains(text(),'{name}')]]//button[./i[@class='oxd-icon bi-trash']]"));

            if (btn_Del.Count == 1)
            {
                btn_Del[0].Click();
                payGradesPage.Btn_ConfirmDelete.Click();
            }
            LoadPage();
        }

        public bool DoesNameHaveCurrencyRecord(string gradeName) 
        {
            ReadOnlyCollection<IWebElement> currencyRecords = 
                    Driver.FindElements(By.XPath("//div[./div/div/div/div/div[text()='" + gradeName + "']]//div[text()='Currency']"));
            return currencyRecords.Count > 0;
        }

        public AddPayGradeContext GoToAddPayGradePage() 
        {
            payGradesPage.Btn_Add.Click();
            return new AddPayGradeContext(Driver);
        }
    }
}
