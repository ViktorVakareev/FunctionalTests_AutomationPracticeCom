using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ShoppingCartPage : BasePage
    {
        public override string Url => "http://automationpractice.com/index.php?controller=order";

        public ShoppingCartPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickProceedToCheckoutButton()
        {
            ProceedToCheckoutButton.Click();
        }

        public void ClickReturnToHomeButton()
        {
            ReturnToHomeButton.Click();
        }

    }
}
