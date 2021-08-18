using FunctionalTests_AutomationPracticeCom.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class AddressesPage : BasePage
    {       
        public string Url => "http://automationpractice.com/index.php?controller=order&step=1&multi-shipping=0";

        public AddressesPage(IWebDriver driver) : base(driver)
        {        
        }
         
        public void ClickUpdateDeliveryAddress()
        {
            DeliveryAddressButton.Click(); ;
        } 
        
        public void ClickUpdateBillingAddress()
        {
            BillingAddressButton.Click(); ;
        }

        public void ClickCreateNewAddress()
        {
            CreateNewAddressButton.Click(); ;
        }

        public void ChooseDeliveryAddress()   // Address Alias
        {
            ChooseDeliveryAddressDropDown.Click(); ;
        }

        public void ClickProceedToCheckpoint()
        {
            ProceedToCheckpointButton.Click(); ;
        }

        public void AddComment()
        {
            AddCommentTextBox.Click(); 
        }

        public void ContinueShopping()
        {
            ContinueShoppingLink.Click(); ;
        }
    }
}
