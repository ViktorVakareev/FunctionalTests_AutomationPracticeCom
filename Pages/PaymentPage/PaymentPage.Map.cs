using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class PaymentPage
    {        
        public IWebElement PayByBankButton => _driver.FindElement(By.Id(""));   
     
        public IWebElement PayByCheckButton => _driver.FindElement(By.Id(""));   
        
        public IWebElement TotalCostField => _driver.FindElement(By.XPath(""));  

        public IWebElement TotalProductsPriceField => _driver.FindElement(By.XPath(""));  

        public IWebElement ContinueShoppingLink => _driver.FindElement(By.LinkText(""));  

        public IWebElement SummarySectionLink => _driver.FindElement(By.LinkText("Summary"));
        
        public IWebElement SignInSectionLink => _driver.FindElement(By.LinkText("Sign in"));
        
        public IWebElement AddressesSectionLink => _driver.FindElement(By.LinkText("Addresses"));  

        public IWebElement ShippingSectionLink => _driver.FindElement(By.LinkText("Shipping"));  
        
        public IWebElement PaymentPageHeading => _driver.FindElement(By.XPath("//h1[@class='page-heading']"));          
    }
}

