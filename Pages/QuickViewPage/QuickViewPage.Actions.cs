using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

        public void ChangeParametersAndAddOrderToCart(IWebElement quantity, IWebElement color, IWebElement sizeDropdown, string size)
        {
            quantity.Click();
            color.Click();
            var selectElement = new SelectElement(sizeDropdown);
            selectElement.SelectByText(size);
            this.AddToCartButton.Click();
        }

        public void ChangeParametersAndAddOrderToCart_WithoutColor(IWebElement quantity, IWebElement sizeDropdown, string size)
        {
            quantity.Click();
            var selectElement = new SelectElement(sizeDropdown);
            selectElement.SelectByText(size);
            this.AddToCartButton.Click();
        }
    }
}
