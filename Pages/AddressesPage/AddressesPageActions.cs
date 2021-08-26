using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class AddressesPage : BasePage
    {
        public override string Url => "http://automationpractice.com/index.php?id_category=8&controller=category";

        public AddressesPage(IWebDriver driver) 
            : base(driver)
        {
        }

        public void ClickUpdateDeliveryAddress()
        {
            DeliveryAddressButton.Click();
        }

        public void ClickUpdateBillingAddress()
        {
            BillingAddressButton.Click();
        }       

        public void ClickCreateNewAddress() 
        {
            CreateNewAddressButton.Click();
        }

        public void ChooseDeliveryAddress() 
        {
            ChooseDeliveryAddressDropDown.Click();
        }          

        public void ClickProceedToCheckpoint() 
        {
            ProceedToCheckpointButton.Click();
        }

        public void AddComment() 
        {
            AddCommentTextBox.Click();
        }

        public void ContinueShopping() 
        {
            ContinueShoppingLink.Click();
        }
    }
}
