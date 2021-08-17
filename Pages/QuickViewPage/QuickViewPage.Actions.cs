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

        public void ClickAddToCart()
        {
            AddToCartButton.Click();
        }

        public void AddOrderToCart(OrderDressInfo order)
        {
            // IWebElement quantity, IWebElement color, IWebElement sizeDropdown, string size
            string dressName = order.DressName;
            string size = order.ColorAndSize.Split(", ")[1];
            string color = order.ColorAndSize.Split(", ")[0];
            int quantity = Int32.Parse(order.Quantity);

            for (int i = 1; i < quantity; i++)
            {
                IncreaseQuantityButton(dressName).Click();
            }
           
            SelectColorByName(dressName,color).Click();
            var selectElement = new SelectElement(SizeDropDownByName(dressName));
            selectElement.SelectByText(size);
            ClickAddToCart();
        }        
    }
}
