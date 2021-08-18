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
    public partial class ShoppingCartPage : BasePage
    {       
        public string Url => "http://automationpractice.com/index.php?controller=order";

        public ShoppingCartPage(IWebDriver driver) : base(driver)
        {        
        }

        public void Open()
        {
            _driver.Navigate().GoToUrl(Url);
        }

        public void ClickProceedToCheckout()
        {
            ProceedToCheckoutButton.Click(); ;
        }
    }
}
