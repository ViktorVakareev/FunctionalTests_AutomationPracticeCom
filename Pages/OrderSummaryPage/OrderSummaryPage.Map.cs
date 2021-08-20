using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class OrderSummaryPage
    { 
        public IWebElement OrderSummaryPageSubHeading => _driver.FindElement(By.XPath("//h3"));

        public IWebElement ConfirmOrderButton => _driver.FindElement(By.XPath("//span[contains(text(),'I confirm my order')]"));

        public IWebElement OtherPaymentMethodsLink => _driver.FindElement(By.XPath("//a[@class='button-exclusive btn btn-default']"));

        public IWebElement SummarySectionLink => _driver.FindElement(By.LinkText("Summary"));

        public IWebElement SignInSectionLink => _driver.FindElement(By.LinkText("Sign in"));

        public IWebElement AddressesSectionLink => _driver.FindElement(By.LinkText("Addresses"));

        public IWebElement ShippingSectionLink => _driver.FindElement(By.LinkText("Shipping"));

        public IWebElement OrderSummaryPageHeading => _driver.FindElement(By.XPath("//h1[@class='page-heading']"));
    }
}

