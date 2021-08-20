using FunctionalTests_AutomationPracticeCom.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class QuickViewPage : BasePage
    {
        private WebDriverWait _wait;

        public override string Url => "http://automationpractice.com/index.php?id_category=8&controller=category";

        public QuickViewPage(IWebDriver driver) : base(driver)
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        public void ClickAddToCart() => AddToCartButton.Click();        

        public void AddOrderToCart(OrderDressInfo order)
        {
            string dressName = order.DressName;
            string size = order.Size;
            string color = order.Color;
            int quantity = order.Quantity;

            QuantityButtonInput().Clear();
            QuantityButtonInput().SendKeys($"{quantity}");
            SelectColorByName(dressName, color).Click();
            var selectElement = new SelectElement(SizeDropDownByName(dressName));
            selectElement.SelectByText(size);
            ClickAddToCart();
        }

        public void ClickProceedToCheckoutButton() 
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(ProceedToCheckoutButtonLocator));
            ProceedToCheckoutButton.Click();
        } 
    }
}
