using Microsoft.OData.Edm;
using NUnit.Framework;
using System;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class FunctionalTests
    {        
        // Login with the shortest email possible - 1 symbol
        // Login shortest password possible - 1 symbol
        // Login shortest username possible - 1 symbol
        // Login with longest email possible - 32 symbols
        // Login with longest username possible - 32 symbols
        // Login with longest password possible - 32 symbols
        // Login with password containing special symbols - !#@$#%^&*()_+
        // Login with email with empty space at beginning - should be trimmed- logged-in successfully
        // Login with email with empty spaces at end - should be trimmed- logged-in successfully
        // Login with username with empty space at beginning - should be trimmed- logged-in successfully
        // Login with username with empty spaces at end - should be trimmed- logged-in successfully
        // Login with password with empty space at beginning - should be trimmed- logged-in successfully
        // Login with password with empty spaces at end - should be trimmed- logged-in successfully
        // Verify that the password is in *** format when entered
        // Verify that the client should not be able to login with the old password after changing the password
        // Login with correct email and password after resetting password
        // Login with correct username and password after resetting password

        [Test]
        [Obsolete]
        public void LoginInWithCorrectEmailAndPassword_When_InAuthenticationPage()
        {
            var personalInfo = new PersonalInfo();
            var validEmail = personalInfo.ValidEmail;
            var validPassword = personalInfo.ValidPassword;

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
            _quickViewPage.ClickProceedToCheckoutButton();
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.EmailSignInTextBox.Clear();
            _authenticationPage.EmailSignInTextBox.SendKeys(validEmail);
            _authenticationPage.PasswordSignInTextBox.Clear();
            _authenticationPage.PasswordSignInTextBox.SendKeys(validPassword);
            _authenticationPage.ClickSignIn();

            _addressesPage.AssertAddressesPageLoaded();
        }

        [Test]
        [Obsolete]
        public void TryLoginWithWrongEmailAndPassword_When_InAuthenticationPage()
        {

            var inValidEmail = "wrong@email.com";
            var inValidPassword = "wrong-pass";

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
            _quickViewPage.ClickProceedToCheckoutButton();
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.EmailSignInTextBox.Clear();
            _authenticationPage.EmailSignInTextBox.SendKeys(inValidEmail);
            _authenticationPage.PasswordSignInTextBox.Clear();
            _authenticationPage.PasswordSignInTextBox.SendKeys(inValidPassword);
            _authenticationPage.ClickSignIn();

            _authenticationPage.AssertValidationMessage("Authentication failed.");
        }

        [Test]
        [Obsolete]
        public void TryLoginWithInvalidEmailAndValidPassword_When_InAuthenticationPage()
        {

            var inValidEmail = "wrong";
            var inValidPassword = "wrong-pass";

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
            _quickViewPage.ClickProceedToCheckoutButton();
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.EmailSignInTextBox.Clear();
            _authenticationPage.EmailSignInTextBox.SendKeys(inValidEmail);
            _authenticationPage.PasswordSignInTextBox.Clear();
            _authenticationPage.PasswordSignInTextBox.SendKeys(inValidPassword);
            _authenticationPage.ClickSignIn();

            _authenticationPage.AssertValidationMessage("Invalid email address.");
        }

        [Test]
        [Obsolete]
        public void TryLoginWithValidEmailAndInvalidPassword_When_InAuthenticationPage()
        {

            var inValidEmail = "valid@email.com";
            var inValidPassword = "w";

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
            _quickViewPage.ClickProceedToCheckoutButton();
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.EmailSignInTextBox.Clear();
            _authenticationPage.EmailSignInTextBox.SendKeys(inValidEmail);
            _authenticationPage.PasswordSignInTextBox.Clear();
            _authenticationPage.PasswordSignInTextBox.SendKeys(inValidPassword);
            _authenticationPage.ClickSignIn();

            _authenticationPage.AssertValidationMessage("Invalid password.");
        }

        [Test]
        [Obsolete]
        public void TryCreateNewAccountWithInvalidEmailAddress_When_InAuthenticationPage()
        {
            var newEmail = "wrong--mail";

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
            _quickViewPage.ClickProceedToCheckoutButton();
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.EmailCreateAccountTextBox.Clear();
            _authenticationPage.EmailCreateAccountTextBox.SendKeys(newEmail);
            _authenticationPage.ClickCreateAccount();

            _authenticationPage.AssertValidationMessage("Invalid email address.");
        }

        [Test]
        [Obsolete]
        public void CreateNewValidAccount_When_InAuthenticationPage()
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

            _addressesPage.AssertAddressesPageLoaded();
            _addressesPage.AssertCreateNewAccountSuccessful(personalInfo, addressInfo);
        }

        // ForgottenPaswordPageTests
        [Test]
        [Obsolete]
        public void OpenForgotYourPasswordLink_When_SigningInFromAuthenticationPage()
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
            _quickViewPage.ClickProceedToCheckoutButton();
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.ClickForgottenPasswordLink();

            _forgottenPasswordPage.AssertForgottenPasswordPageLoaded();
        }

        [Test]
        [Obsolete]
        public void TryRetrievePasswordWithInvalidEmail_When_InForgottenPasswordPage()
        {
            var email = "wrong_mail@gmail.com";

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
            _quickViewPage.ClickProceedToCheckoutButton();
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.ClickForgottenPasswordLink();
            _forgottenPasswordPage.EmailInputField.Clear();
            _forgottenPasswordPage.EmailInputField.SendKeys(email);
            _forgottenPasswordPage.ClickRetrievePasswordButton();

            _forgottenPasswordPage.AssertRetriveForgottenPasswordErrorMessage();
        }

        [Test]
        [Obsolete]
        public void RetrievePasswordWithValidEmail_When_InForgottenPasswordPage()
        {
            var personalInfo = new PersonalInfo();
            var validEmail = personalInfo.ValidEmail;

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
            _quickViewPage.ClickProceedToCheckoutButton();
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.ClickForgottenPasswordLink();
            _forgottenPasswordPage.EmailInputField.Clear();
            _forgottenPasswordPage.EmailInputField.SendKeys(validEmail);
            _forgottenPasswordPage.ClickRetrievePasswordButton();

            _forgottenPasswordPage.AssertRetriveForgottenPasswordConfirmationMessage(validEmail);
        }
    }
}
