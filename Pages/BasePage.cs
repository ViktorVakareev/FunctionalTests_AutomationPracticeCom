using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;

        public abstract string Url { get; }

        public void Open()
        {
            _driver.Navigate().GoToUrl(Url);
        }

        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
        }                    
    }
}
