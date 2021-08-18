using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver) => _driver = driver;
    }
}
