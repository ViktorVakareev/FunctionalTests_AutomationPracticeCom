using FunctionalTests_AutomationPracticeCom.Pages;
using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ShippingPage : BasePage
    {
        public override string Url => "http://automationpractice.com/index.php?id_cms=3&controller=cms&content_only=1";

        public ShippingPage(IWebDriver driver) : base(driver)
        {        
        }
         
        public void ClickAgreeToTermsCheckBox() => AgreeToTermsCheckBox.Click();

        public void ClickReadTheTermsLink()
        {
            ReadTheTermsLink.Click();
            _driver.SwitchTo().Frame(ReadTheTermsIframeWindow);
        }
        

        public void ClickProceedToCheckpointButton() => ProceedToCheckpointButton.Click();
    }
}
