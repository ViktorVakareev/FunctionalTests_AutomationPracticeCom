using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class AddressesPage
    {
        public IWebElement DeliveryAddressButton => _driver.FindElement(By.Id(""));

        public IWebElement BillingAddressButton => _driver.FindElement(By.Id("")); 
        
        public IWebElement CreateNewAddressButton => _driver.FindElement(By.Id(""));    

        public IWebElement ChooseDeliveryAddressDropDown => _driver.FindElement(By.Id(""));     
        
        public IWebElement ProceedToCheckpointButton => _driver.FindElement(By.XPath("//button[@name='processAddress']"));   
        
        public IWebElement AddCommentTextBox => _driver.FindElement(By.LinkText(""));
        
        public IWebElement DeliveryAddressNameField => _driver.FindElement(By.XPath("address_firstname address_lastname"));  

        public IWebElement DeliveryAddress_AddressField => _driver.FindElement(By.ClassName("address_address1 address_address2")); 
        
        public IWebElement DeliveryAddressCityStateZipField => _driver.FindElement(By.ClassName("address_city address_state_name address_postcode")); 
        
        public IWebElement DeliveryAddressCountryField => _driver.FindElement(By.ClassName("address_country_name")); 
        
        public IWebElement DeliveryAddressMobilePhoneField => _driver.FindElement(By.ClassName("address_phone_mobile"));  

        public IWebElement ContinueShoppingLink => _driver.FindElement(By.XPath("//a[@title='Previous']"));  

        public IWebElement AddressesAreEqualCheckBox => _driver.FindElement(By.Id("addressesAreEquals"));  

        public IWebElement SummarySectionLink => _driver.FindElement(By.LinkText("Summary"));
        
        public IWebElement SignInSectionLink => _driver.FindElement(By.LinkText("Sign in"));  
        
        public IWebElement AddressesPageHeading => _driver.FindElement(By.XPath("//h1[@class='page-heading']"));          
    }
}

