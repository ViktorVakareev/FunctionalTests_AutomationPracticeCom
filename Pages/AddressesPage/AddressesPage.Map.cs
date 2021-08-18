using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class AddressesPage
    {
        public IWebElement DeliveryAddressButton => _driver.FindElement(By.Id(""));

        public IWebElement BillingAddressButton => _driver.FindElement(By.Id("")); 
        
        public IWebElement CreateNewAddressButton => _driver.FindElement(By.Id(""));    

        public IWebElement ChooseDeliveryAddressDropDown => _driver.FindElement(By.Id(""));     
        
        public IWebElement ProceedToCheckpointButton => _driver.FindElement(By.Id(""));   
        
        public IWebElement AddCommentTextBox => _driver.FindElement(By.LinkText(""));  

        public IWebElement ContinueShoppingLink => _driver.FindElement(By.LinkText(""));  

        public IWebElement AddressesAreEqualCheckBox => _driver.FindElement(By.Id("addressesAreEquals"));  

        public IWebElement SummarySectionLink => _driver.FindElement(By.LinkText("Summary"));
        
        public IWebElement SummarySignInLink => _driver.FindElement(By.LinkText("Sign in"));  
        
        public IWebElement AddressesPageHeading => _driver.FindElement(By.XPath("//h1[@class='page-heading']"));          
    }
}

