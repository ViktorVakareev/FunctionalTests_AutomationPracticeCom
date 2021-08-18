using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class CreateAccountPage
    {
        public IWebElement RegisterButton => _driver.FindElement(By.Id("submitAccount"));

        public IWebElement TitleRadioButton_Mr => _driver.FindElement(By.Id("")); 

        public IWebElement TitleRadioButton_Mrs => _driver.FindElement(By.Id("")); 
        
        public IWebElement FirstNameTextBox => _driver.FindElement(By.Id(""));    

        public IWebElement LastNameTextBox => _driver.FindElement(By.Id(""));     
        
        public IWebElement EmailTextBox => _driver.FindElement(By.Id(""));   
        
        public IWebElement PasswordTextBox => _driver.FindElement(By.XPath(""));  

        public IWebElement DateDropDown => _driver.FindElement(By.XPath(""));  

        public IWebElement MonthDropDown => _driver.FindElement(By.XPath(""));  

        public IWebElement YearDropDown => _driver.FindElement(By.XPath(""));

        public IWebElement AddressTextBox => _driver.FindElement(By.XPath(""));

        public IWebElement CityTextBox => _driver.FindElement(By.XPath(""));

        public IWebElement StateDropDown => _driver.FindElement(By.XPath(""));

        public IWebElement ZipTextBox => _driver.FindElement(By.XPath(""));

        public IWebElement CountryDropDown => _driver.FindElement(By.XPath(""));

        public IWebElement MobilePhoneTextBox => _driver.FindElement(By.XPath(""));

        public IWebElement AddressAliasTextBox => _driver.FindElement(By.XPath(""));

        public IWebElement NewsLetterCheckBox => _driver.FindElement(By.Id("newsletter"));

        public IWebElement OffersLetterCheckBox => _driver.FindElement(By.Id("optin"));

        public IWebElement SummarySectionLink => _driver.FindElement(By.LinkText("Summary"));  
        
        public IWebElement CreateAccountPageHeading => _driver.FindElement(By.XPath("//h1[@class='page-heading']"));          
    }
}

