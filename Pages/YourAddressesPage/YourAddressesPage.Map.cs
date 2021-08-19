using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class YourAddressesPage
    {       
        public IWebElement AddressTextBox => _driver.FindElement(By.XPath(""));

        public IWebElement CityTextBox => _driver.FindElement(By.XPath(""));

        public IWebElement StateDropDown => _driver.FindElement(By.XPath(""));

        public IWebElement ZipTextBox => _driver.FindElement(By.XPath(""));
        
        public IWebElement MobilePhoneTextBox => _driver.FindElement(By.XPath(""));

        public IWebElement NewAddressAliasTextBox => _driver.FindElement(By.XPath(""));

        public IWebElement SaveButton => _driver.FindElement(By.LinkText(""));  

        public IWebElement BackToYourAddressesLink => _driver.FindElement(By.LinkText(""));                  
        
        public IWebElement YourAddressesPageHeading => _driver.FindElement(By.XPath("//h1[@class='page-heading']"));          
    }
}

