using FunctionalTests_AutomationPracticeCom.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class CreateAccountPage : BasePage
    {
        public override string Url => "http://automationpractice.com/index.php?id_category=8&controller=category";

        public CreateAccountPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickRegisterButton() => RegisterButton.Click();

        public void FillInNewAccountInfo(PersonalInfo personalInfo, AddressInfo addressInfo)
        {
            TitleRadioButton(personalInfo.Title).Click();
            FirstNameTextBox.SendKeys(personalInfo.FirstName);
            LastNameTextBox.SendKeys(personalInfo.LastName);            
            PasswordTextBox.SendKeys(personalInfo.Password);
            //SelectDateFromDropDown(DayDropDown, MonthDropDown, YearDropDown, personalInfo.DateOfBirth.Day, personalInfo.DateOfBirth.Month, personalInfo.DateOfBirth.Year);
            AddressTextBox.SendKeys(addressInfo.Address);
            CityTextBox.SendKeys(addressInfo.City);
            StateDropDown.SelectElementFromDropDownByName(addressInfo.State);            
            ZipTextBox.SendKeys(addressInfo.Zip);
            CountryDropDown.SelectElementFromDropDownByName(addressInfo.Country);
            MobilePhoneTextBox.SendKeys(addressInfo.MobilePhone);
            AddressAliasTextBox.SendKeys(addressInfo.AddressAlias);
        }        
    }
}
