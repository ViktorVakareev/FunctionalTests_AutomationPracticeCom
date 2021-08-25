using FunctionalTests_AutomationPracticeCom.Pages;
using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class YourAddressesPage : BasePage
    {
        public override string Url => "http://automationpractice.com/index.php?id_category=8&controller=category";

        public YourAddressesPage(IWebDriver driver) : base(driver)
        {        
        }
         
        public void ClickBackToYourAddressesLink() 
        {
            BackToYourAddressesLink.Click();
        }

        public void ClickSaveButton() 
        {
            SaveButton.Click();
        }
               
    }
}
