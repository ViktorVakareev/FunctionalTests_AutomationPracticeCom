using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class OrderConfirmationPage
    { 
        public IWebElement OrderCompletedMessage => _driver.FindElement(By.XPath("//p[@class='alert alert-success']"));

        public IWebElement BackToOrdersLink => _driver.FindElement(By.XPath("//a[@title='Back to orders']"));

        public IWebElement OrderConfirmationPageHeading => _driver.FindElement(By.XPath("//h1[@class='page-heading']"));
    }
}

