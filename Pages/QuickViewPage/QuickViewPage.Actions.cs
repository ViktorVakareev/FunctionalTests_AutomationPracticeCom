using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class QuickViewPage
    {
        private IWebDriver _driver;
        
        public string Url => "http://automationpractice.com/index.php?id_category=8&controller=category";

        public QuickViewPage(IWebDriver driver) => _driver = driver;

        public void Open()
        {
            _driver.Navigate().GoToUrl(Url);
        }             
    }
}
