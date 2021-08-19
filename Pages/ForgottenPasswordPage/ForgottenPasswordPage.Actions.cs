using FunctionalTests_AutomationPracticeCom.Pages;
using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ForgottenPasswordPage : BasePage
    {
        public override string Url => "http://automationpractice.com/index.php?id_category=8&controller=category";

        public ForgottenPasswordPage(IWebDriver driver) : base(driver)
        {        
        }
         
        public void ClickBackToLoginLink() => BackToLoginLink.Click();

        public void ClickRetrievePasswordButton() => RetrievePasswordButton.Click();
    }
}
