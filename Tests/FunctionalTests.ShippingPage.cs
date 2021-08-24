using Microsoft.OData.Edm;
using NUnit.Framework;
using System;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class FunctionalTests
    {
        [Test]
        [Obsolete]
        public void ShippingCostIsTheRightAmountBeforePayment_When_InShippingPage()
        {
            var newEmail = HelperMethods.GenerateNewRandomEmailOrPassword();
            var newPassword = HelperMethods.GenerateNewRandomEmailOrPassword();
            var dateOfBirth = new Date(1981, 7, 20);
            var personalInfo = new PersonalInfo()
            {
                Title = "Mr.",
                FirstName = "Jimmy",
                LastName = "Fallon",
                Password = newPassword,
                DateOfBirth = dateOfBirth
            };
            var addressInfo = new AddressInfo()
            {
                FirstName = "Jimmy",
                LastName = "Fallon",
                Address = "22, Jump Street",
                City = "Tom's River",
                State = "New Jersey",
                Zip = "08751",
                Country = "United States",
                MobilePhone = "222555888",
                AddressAlias = "Jimmy's Home"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
            _quickViewPage.ClickProceedToCheckoutButton();
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.EmailCreateAccountTextBox.Clear();
            _authenticationPage.EmailCreateAccountTextBox.SendKeys(newEmail);
            _authenticationPage.ClickCreateAccount();
            _createAccountPage.FillInNewAccountInfo(personalInfo, addressInfo);
            _createAccountPage.ClickRegisterButton();
            _addressesPage.ClickProceedToCheckpoint();

            _shippingCartPage.AssertShippingPageLoaded();
            _shippingCartPage.AssertDeliveryPriceIsRightAmount();
        }

        [Test]
        [Obsolete]
        public void ReadTermsOfServiceLinkWorking_When_InShippingPage()
        {
            var newEmail = HelperMethods.GenerateNewRandomEmailOrPassword();
            var newPassword = HelperMethods.GenerateNewRandomEmailOrPassword();
            var dateOfBirth = new Date(1981, 7, 20);
            var personalInfo = new PersonalInfo()
            {
                Title = "Mr.",
                FirstName = "Jimmy",
                LastName = "Fallon",
                Password = newPassword,
                DateOfBirth = dateOfBirth
            };
            var addressInfo = new AddressInfo()
            {
                FirstName = "Jimmy",
                LastName = "Fallon",
                Address = "22, Jump Street",
                City = "Tom's River",
                State = "New Jersey",
                Zip = "08751",
                Country = "United States",
                MobilePhone = "222555888",
                AddressAlias = "Jimmy's Home"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
            _quickViewPage.ClickProceedToCheckoutButton();
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.EmailCreateAccountTextBox.Clear();
            _authenticationPage.EmailCreateAccountTextBox.SendKeys(newEmail);
            _authenticationPage.ClickCreateAccount();
            _createAccountPage.FillInNewAccountInfo(personalInfo, addressInfo);
            _createAccountPage.ClickRegisterButton();
            _addressesPage.ClickProceedToCheckpoint();
            _shippingCartPage.ClickReadTheTermsLink();

            _shippingCartPage.AssertReadTheTermsLinkFollowed();
        }

        [Test]
        [Obsolete]        
        public void AgreeToTermsErrorMessage_When_TryingToProceedToPaymentPageFromShippingPage()
        {
            var newEmail = HelperMethods.GenerateNewRandomEmailOrPassword();
            var newPassword = HelperMethods.GenerateNewRandomEmailOrPassword();
            var dateOfBirth = new Date(1981, 7, 20);
            var personalInfo = new PersonalInfo()
            {
                Title = "Mr.",
                FirstName = "Jimmy",
                LastName = "Fallon",
                Password = newPassword,
                DateOfBirth = dateOfBirth
            };
            var addressInfo = new AddressInfo()
            {
                FirstName = "Jimmy",
                LastName = "Fallon",
                Address = "22, Jump Street",
                City = "Tom's River",
                State = "New Jersey",
                Zip = "08751",
                Country = "United States",
                MobilePhone = "222555888",
                AddressAlias = "Jimmy's Home"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
            _quickViewPage.ClickProceedToCheckoutButton();
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.EmailCreateAccountTextBox.Clear();
            _authenticationPage.EmailCreateAccountTextBox.SendKeys(newEmail);
            _authenticationPage.ClickCreateAccount();
            _createAccountPage.FillInNewAccountInfo(personalInfo, addressInfo);
            _createAccountPage.ClickRegisterButton();
            _addressesPage.ClickProceedToCheckpoint();
            _shippingCartPage.ClickProceedToCheckpointButton();

            _shippingCartPage.AssertAgreeToTermsErrorMessage();
        }
    }
}
