using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class OrderConfirmationPage : BasePage
    {
        public override string Url => "http://automationpractice.com/index.php?fc=module&module=cheque&controller=payment";

        public OrderConfirmationPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickBackToOrdersLink() 
        {
            BackToOrdersLink.Click();
        }            
    }
}
