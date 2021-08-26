using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class PaymentPage : BasePage
    {
        public override string Url => "http://automationpractice.com/index.php?fc=module&module=cheque&controller=payment";

        public PaymentPage(IWebDriver driver) 
            : base(driver)
        {
        }
        public void ClickPayByBankWireLink()
        {
            PayByBankWireLink.Click();
        }

        public void ClickPayByCheckLink()
        {
            PayByCheckLink.Click();
        }
    }
}
