using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ProductComparisonPage
    {
        private IWebDriver _driver;

        public string Url => "http://automationpractice.com/index.php?controller=products-comparison";

        public ProductComparisonPage(IWebDriver driver) => _driver = driver;

        public void Open()
        {
            _driver.Navigate().GoToUrl(Url);
        }        
    }
}
