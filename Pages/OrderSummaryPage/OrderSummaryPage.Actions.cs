using FunctionalTests_AutomationPracticeCom.Pages;
using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class OrderSummaryPage : BasePage
    {
        public override string Url => "http://automationpractice.com/index.php?fc=module&module=cheque&controller=payment";

        public OrderSummaryPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickConfirmOrderButton()
        {
            ConfirmOrderButton.Click();
        }

        public void ClickOtherPaymentMethodsLink()
        {
            OtherPaymentMethodsLink.Click();
        }
    }
}
