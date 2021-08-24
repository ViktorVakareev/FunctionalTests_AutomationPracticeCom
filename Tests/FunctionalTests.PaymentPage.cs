using Microsoft.OData.Edm;
using NUnit.Framework;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class FunctionalTests
    {
        [Test]
        [System.Obsolete]
        public void PaymentPageLoadedCorrectly_When_ClickingProceedToCheckoutFromShippingPage()
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
            _shippingCartPage.ClickAgreeToTermsCheckBox();
            _shippingCartPage.ClickProceedToCheckpointButton();

            _paymentPage.AssertPaymentPageLoaded();
        }

        [Test]
        [System.Obsolete]
        public void PayByBankWire_When_InPaymentPage()
        {
            var newEmail = HelperMethods.GenerateNewRandomEmailOrPassword();
            var newPassword = HelperMethods.GenerateNewRandomEmailOrPassword();
            var dateOfBirth = new Date(1981, 7, 20);
            var personalInfo = new PersonalInfo()
            {
                Title = "Mr.",
                FirstName = "Jimmy",
                LastName = "Fallon",
                Password = newPassword                
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
            _shippingCartPage.ClickAgreeToTermsCheckBox();
            _shippingCartPage.ClickProceedToCheckpointButton();
            _paymentPage.ClickPayByBankWireLink();

            _orderSummaryPage.AssertOrderSummaryBankWirePaymentPageLoaded();
        }

        [Test]
        [System.Obsolete]
        public void PayByCheck_When_InPaymentPage()
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
                AddressAlias = "Jimmy's Home",

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
            _shippingCartPage.ClickAgreeToTermsCheckBox();
            _shippingCartPage.ClickProceedToCheckpointButton();
            _paymentPage.ClickPayByCheckLink();

            _orderSummaryPage.AssertOrderSummaryCheckPaymentPageLoaded();
        }
    }
}
