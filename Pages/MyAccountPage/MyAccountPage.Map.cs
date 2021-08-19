using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class MyAccountPage
    {      
        public IWebElement OrderHistoryAndDetailsButton => _driver.FindElement(By.Id(""));

        public IWebElement MyCreditSlipsButton => _driver.FindElement(By.Id(""));

        public IWebElement MyAddressesButton => _driver.FindElement(By.Id(""));

        public IWebElement MyPersonalInformationButton => _driver.FindElement(By.LinkText(""));  

        public IWebElement MyWishListsButton => _driver.FindElement(By.LinkText(""));    

        public IWebElement ReturnToHomeButton => _driver.FindElement(By.XPath("//a[@class='home']"));

        public IWebElement MyAccountPageHeading => _driver.FindElement(By.XPath("//h1[@class='page-heading']")); 
    }
}

