using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ShippingPage
    {      
        public IWebElement ProceedToCheckpointButton => _driver.FindElement(By.Id(""));

        public IWebElement AgreeToTermsCheckBox => _driver.FindElement(By.Id(""));

        public IWebElement ReadTheTermsLink => _driver.FindElement(By.Id(""));

        public IWebElement ShippingCostField => _driver.FindElement(By.LinkText(""));  

        public IWebElement ContinueShoppingLink => _driver.FindElement(By.LinkText(""));  
        
        public IWebElement SummarySectionLink => _driver.FindElement(By.LinkText("Summary"));
        
        public IWebElement SignInSectionLink => _driver.FindElement(By.LinkText("Sign in")); 
        
        public IWebElement AddressSectionLink => _driver.FindElement(By.LinkText("Address"));  
        
        public IWebElement ShippingPageHeading => _driver.FindElement(By.XPath("//h1[@class='page-heading']"));  
        
        public IWebElement AgreeToTermsErrorMessage => _driver.FindElement(By.XPath("//p[@class='fancybox-error']"));          
    }
}

