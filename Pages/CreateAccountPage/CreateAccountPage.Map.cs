using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class CreateAccountPage
    {
        public IWebElement RegisterButton => _driver.FindElement(By.Id("submitAccount"));

        public IWebElement TitleRadioButton(string title)
        {
            if (title.Equals("Mr."))
            {
                return _driver.FindElement(By.XPath("//input[@id='id_gender1']"));
            }
            else   // Mrs.
            {
                return _driver.FindElement(By.XPath("//input[@id='id_gender2']"));
            }            
        }

        public IWebElement FirstNameTextBox => _driver.FindElement(By.Id("customer_firstname"));

        public IWebElement LastNameTextBox => _driver.FindElement(By.Id("customer_lastname"));

        public IWebElement EmailTextBox => _driver.FindElement(By.Id("email"));

        public IWebElement PasswordTextBox => _driver.FindElement(By.Id("passwd"));

        public IWebElement DayDropDown => _driver.FindElement(By.Id("days"));

        public IWebElement MonthDropDown => _driver.FindElement(By.Id("months"));

        public IWebElement YearDropDown => _driver.FindElement(By.Id("years"));

        public IWebElement AddressTextBox => _driver.FindElement(By.Id("address1"));

        public IWebElement CityTextBox => _driver.FindElement(By.Id("city"));

        public IWebElement StateDropDown => _driver.FindElement(By.Id("id_state"));

        public IWebElement ZipTextBox => _driver.FindElement(By.Id("postcode"));

        public IWebElement CountryDropDown => _driver.FindElement(By.Id("id_country"));

        public IWebElement MobilePhoneTextBox => _driver.FindElement(By.Id("phone_mobile"));

        public IWebElement AddressAliasTextBox => _driver.FindElement(By.Id("alias"));

        public IWebElement NewsLetterCheckBox => _driver.FindElement(By.Id("newsletter"));

        public IWebElement OffersLetterCheckBox => _driver.FindElement(By.Id("optin"));

        public IWebElement SummarySectionLink => _driver.FindElement(By.LinkText("Summary"));

        public IWebElement CreateAccountPageHeading => _driver.FindElement(By.XPath("//h1[@class='page-heading']"));
    }
}

