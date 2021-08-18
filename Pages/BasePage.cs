using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;

        public abstract string Url { get; }

        public void Open() => _driver.Navigate().GoToUrl(Url);

        protected BasePage(IWebDriver driver) => _driver = driver;          
    }
}
