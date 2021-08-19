using FunctionalTests_AutomationPracticeCom.Pages;
using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ShippingPage : BasePage
    {
        public override string Url => "http://automationpractice.com/index.php?id_category=8&controller=category";

        public ShippingPage(IWebDriver driver) : base(driver)
        {        
        }
         
        public void ClickAgreeToTermsCheckBox() => AgreeToTermsCheckBox.Click();

        public void ClickReadTheTermsLink() => ReadTheTermsLink.Click();

        public void ClickProceedToCheckpointButton() => ProceedToCheckpointButton.Click();
    }
}
