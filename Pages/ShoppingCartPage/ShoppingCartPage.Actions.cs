using FunctionalTests_AutomationPracticeCom.Pages;
using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ShoppingCartPage : BasePage
    {
        public override string Url => "http://automationpractice.com/index.php?controller=order";

        public ShoppingCartPage(IWebDriver driver) : base(driver)
        {        
        }

        public void ClickProceedToCheckout() => ProceedToCheckoutButton.Click();        

        public void ClickReturnToHomeButton() => ReturnToHomeButton.Click();
    }
}
