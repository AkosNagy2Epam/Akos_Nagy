using WebUI.Entities;
using WebUI.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;

namespace WebUI.Contexts
{
    public class EditPayGradeContext : ContextBase
    {
        EditPayGradePage editPayGradePage;
        public EditPayGradeContext(IWebDriver driver) : base(driver)
        {
            editPayGradePage = new EditPayGradePage();
            PageFactory.InitElements(driver, editPayGradePage);
            LoadPage();
        }

        public override bool LoadPage()
        {
            return Wait.Until(d => editPayGradePage.Txt_Found.Displayed == true);
        }
        public bool LoadSalaryRecords()
        {
            return Wait.Until(d => editPayGradePage.Txt_MinRecord.Displayed == true);
        }

        public void EnterNewSalaryData(CurrencyNames name, int minSalary, int maxSalary) 
        {
            editPayGradePage.Btn_Add.Click();
            editPayGradePage.Lb_CurrencyName.Click();
            Driver.FindElement(By.XPath($"//span[contains(text(),'{name.ToString()}')]")).Click();
            editPayGradePage.Tb_MinSalary.SendKeys(minSalary.ToString());
            editPayGradePage.Tb_MaxSalary.SendKeys(maxSalary.ToString());
        }
        public void SaveNewSalary() 
        { 
            editPayGradePage.Btn_SaveAddCurrency.Click();
            LoadSalaryRecords();
            
        }
        public PayGradesContext CancelBackToPayGradesPage() 
        {
            editPayGradePage.Btn_CancelEditGrade.Click();
            return new PayGradesContext(Driver);
        }
        public void AddCurrency(CurrencyNames name, int minSalary, int maxSalary) 
        {
            EnterNewSalaryData(name, minSalary, maxSalary);
            SaveNewSalary();
        
        }
        
        public SalaryGradeData GetSingleSalaryGrade() 
        {
            SalaryGradeData result= new SalaryGradeData();
            double min;
            double max;
            if (double.TryParse(editPayGradePage.Txt_MinRecord.Text, out min)) result.MinSalary = min;
            else result.MinSalary = -1;
            if (double.TryParse(editPayGradePage.Txt_MaxRecord.Text, out max)) result.MaxSalary = max;
            else result.MaxSalary = -1;
            return result;
        }

        public enum CurrencyNames
        {
            HUF, USD, GBP
        }
    }

    

}
