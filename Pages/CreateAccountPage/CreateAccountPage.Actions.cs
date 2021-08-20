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
            EmailTextBox.SendKeys(personalInfo.Email);
            PasswordTextBox.SendKeys(personalInfo.Password);
            SelectDateFromDropDown(DayDropDown, MonthDropDown, YearDropDown,
                personalInfo.DateOfBirth.Day,personalInfo.DateOfBirth.Month, personalInfo.DateOfBirth.Year);            
            AddressTextBox.SendKeys(addressInfo.Address);
            CityTextBox.SendKeys(addressInfo.City);
            SelectFromDropDown(StateDropDown, addressInfo.State);  
            ZipTextBox.SendKeys(addressInfo.Zip);
            SelectFromDropDown(CountryDropDown, addressInfo.Country);            
            MobilePhoneTextBox.SendKeys(addressInfo.MobilePhone);
            AddressAliasTextBox.SendKeys(addressInfo.AddressAlias);
        }

        private static void SelectFromDropDown(IWebElement element, string name)
        {
            var selectElement = new SelectElement(element);            
            selectElement.SelectByText(name);            
        }

        private static void SelectDateFromDropDown(IWebElement dayElement, IWebElement monthElement, IWebElement yearElement,
            int day, int month, int year)
        {            
            var selectElementDay = new SelectElement(dayElement);
            selectElementDay.SelectByText(day.ToString());
            var selectElementMonth = new SelectElement(monthElement);
            selectElementMonth.SelectByText(month.ToString());
            var selectElementYear = new SelectElement(yearElement);
            selectElementYear.SelectByText(year.ToString());
        }
    }
}
