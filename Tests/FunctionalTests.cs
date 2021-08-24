﻿using Microsoft.OData.Edm;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    [TestFixture]
    public partial class FunctionalTests

    {
        private IWebDriver _driver;
        protected MainPage _mainPage;
        private QuickViewPage _quickViewPage;
        private ProductComparisonPage _productComparisonPage;
        private ShoppingCartPage _shoppingCartPage;
        private AuthenticationPage _authenticationPage;
        private CreateAccountPage _createAccountPage;
        private AddressesPage _addressesPage;
        private YourAddressesPage _yourAddressesPage;
        private ShippingPage _shippingCartPage;
        private PaymentPage _paymentPage;
        private ForgottenPasswordPage _forgottenPasswordPage;
        private OrderSummaryPage _orderSummaryPage;
        private OrderConfirmationPage _orderConfirmation;
        private MyAccountPage _myAccountPage;        

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            _driver.Manage().Window.Maximize();
            _mainPage = new MainPage(_driver);
            _quickViewPage = new QuickViewPage(_driver);
            _productComparisonPage = new ProductComparisonPage(_driver);
            _shoppingCartPage = new ShoppingCartPage(_driver);
            _authenticationPage = new AuthenticationPage(_driver);
            _addressesPage = new AddressesPage(_driver);
            _createAccountPage = new CreateAccountPage(_driver);
            _yourAddressesPage = new YourAddressesPage(_driver);
            _shippingCartPage = new ShippingPage(_driver);
            _paymentPage = new PaymentPage(_driver);
            _forgottenPasswordPage = new ForgottenPasswordPage(_driver);
            _orderSummaryPage = new OrderSummaryPage(_driver);
            _orderConfirmation = new OrderConfirmationPage(_driver);
            _myAccountPage = new MyAccountPage(_driver);
        }

        [TearDown]
        public void CleanUp()
        {
            _driver.Quit();
        }

        private static string GenerateNewRandomEmailOrPassword()
        {
            var guid = new Guid();
            return $"vic{guid}@gmail.com";
        }

        // MainPage and QuickViewPage Tests
        
        
                
        [Test]
        [Obsolete]
        public void ValidateDressInfoOnPreCheckoutScreen_When_PrintedChiffonDressAddedToCart()
        {
            var expectedDressInfo = new OrderDressInfo()
            {
                DressName = "Printed Chiffon Dress",
                Color = "Yellow",
                Size = "S",
                Quantity = 1,
                Price = "$16.40"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.AddToCartButton.Click();
            _mainPage.WaitUntilProductIsAddeToCart();

            _mainPage.AssertValidDress(expectedDressInfo);
        }

        [Test]
        [Obsolete]
        public void ValidateDressInfoOnPreCheckoutScreen_When_PrintedDressWithChangedParametersAddedToCart()
        {
            var order = new OrderDressInfo()
            {
                DressName = "Printed Dress",
                Color = "Orange",
                Size = "L",
                Quantity = 2,
                Price = "$52.00"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Dress");
            _quickViewPage.AddOrderToCart(order);
            _mainPage.WaitUntilProductIsAddeToCart();

            _mainPage.AssertValidDress(order);
        }

        [Test]
        [Obsolete]
        public void ValidateDressInfoOnPreCheckoutScreen_When_PrintedSummerDressWithChangedParametersAddedToCart()
        {
            var order = new OrderDressInfo()
            {
                DressName = "Printed Summer Dress",
                Color = "Blue",
                Size = "L",
                Quantity = 2,
                Price = "$57.96"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Summer Dress");
            _quickViewPage.AddOrderToCart(order);
            _mainPage.WaitUntilProductIsAddeToCart();
            _mainPage.AssertValidDress(order);
        }

        [Test]
        public void ValidateDressInfoOnPreCheckoutScreen_When_PrintedChiffonDressWithChangedParametersAddedToCart()
        {
            var order = new OrderDressInfo()
            {
                DressName = "Printed Chiffon Dress",
                Color = "Green",
                Size = "M",
                Quantity = 6,
                Price = "$98.40"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.AddOrderToCart(order);
#pragma warning disable CS0612 // Type or member is obsolete
            _mainPage.WaitUntilProductIsAddeToCart();
#pragma warning restore CS0612 // Type or member is obsolete

            _mainPage.AssertValidDress(order);
        }

        // ProductComparisonPage Tests
        [Test]
        public void CorrectProductsAreCompared_When_ProductComparisonPageLoaded()
        {
            var dressesToCompare = new List<OrderDressInfo>();
            var dress1 = new OrderDressInfo()
            {
                DressName = "Printed Summer Dress",
                Color = "Yellow",
                Size = "S",
                Quantity = 1,
                Price = "$28.98"
            };
            var dress2 = new OrderDressInfo()
            {
                DressName = "Printed Chiffon Dress",
                Color = "Yellow",
                Size = "S",
                Quantity = 1,
                Price = "$16.40"
            };

            dressesToCompare.Add(dress1);
            dressesToCompare.Add(dress2);

            _mainPage.Open();
            _mainPage.AddToCompare("Printed Summer Dress", 5);
            _mainPage.AddToCompare("Printed Chiffon Dress", 7);
            _mainPage.CompareButtonClick();

            _productComparisonPage.AssertCorrectProductAddedToProductComparisonPage(dressesToCompare);
        }

        [Test]
        public void ProductComparisonPageLoaded_When_ProductsAddedToCompare()
        {
            _mainPage.Open();
            _mainPage.AddToCompare("Printed Summer Dress", 5);
            _mainPage.AddToCompare("Printed Chiffon Dress", 7);
            _mainPage.CompareButtonClick();

            _productComparisonPage.AssertComparisonPageLoaded();
        }

        [Test]
        public void ErrorMessage_When_TryingToCompareMoreThanThreeProducts()
        {
            _mainPage.Open();
            _mainPage.AddToCompare("Printed Dress", 3);
            _mainPage.AddToCompare("Printed Summer Dress", 5);
            _mainPage.AddToCompare("Printed Chiffon Dress", 7);
            _mainPage.AddToCompare("Printed Dress", 4, "2");
            _mainPage.AddToCompare("Printed Summer Dress", 6, "2");
            _mainPage.AddToCompare("Printed Summer Dress", 5);
            _mainPage.CompareButtonClick();

            _mainPage.AssertProductComparisonErrorMessage();
        }

        // ShoppingCartPage Tests
        [Test]
        public void CorrectMessageDisplayed_When_ViewMyShoppingCartLinkClickedInMainPage()
        {
            _mainPage.Open();
            _mainPage.ClickViewMyShoppingCartButton();

            _shoppingCartPage.AssertEmptyShoppingCartMessageDisplayed();
        }

        [Test]
        public void ShoppingCartPageLoadedCorrectly_When_ProductAddedToCartFromQuickView()
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete

            _shoppingCartPage.AssertShoppingCartPageLoaded();
        }

        [Test]
        public void CorrectTotalPriceCalculatedInShoppingCard_When_ProductAddedToCartFromQuickView()
        {
            var order = new OrderDressInfo()
            {
                DressName = "Printed Chiffon Dress",
                Color = "Green",
                Size = "M",
                Quantity = 6,
                Price = "$98.40"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.AddOrderToCart(order);
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete

            _shoppingCartPage.AssertCorrectTotalPriceInShoppingCart(order);
        }

        [Test]
        public void CorrectShoppingCartPageProductInfo_When_ProductAddedToCartFromQuickView()
        {
            var order = new OrderDressInfo()
            {
                DressName = "Printed Chiffon Dress",
                Color = "Green",
                Size = "M",
                Quantity = 6,
                Price = "$98.40"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.AddOrderToCart(order);
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete

            _shoppingCartPage.AssertCorrectProductAddedToShoppingCart(order);
        }

        // AuthenticationPage Tests
        //// TODO Create Account with invalid info and assert validation error messages!
// Login with the shortest email possible
// Login shortest password possible
// Login shortest username possible
// Login with longest email possible
// Login with longest username possible
// Login with longest password possible
// Login with password containing special symbols
// Login with email with empty space at beginning - should be trimmed- logged-in successfully
// Login with email with empty spaces at end - should be trimmed- logged-in successfully
// Login with username with empty space at beginning - should be trimmed- logged-in successfully
// Login with username with empty spaces at end - should be trimmed- logged-in successfully
// Login with password with empty space at beginning - should be trimmed- logged-in successfully
// Login with password with empty spaces at end - should be trimmed- logged-in successfully
// Verify that the password is in *** format when entered
// Verify that the client should not be able to login with the old password after changing the password

        [Test]
        [Obsolete]
        public void SignInWithValidRegistration_When_InAuthenticationPage()
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
        public void TryToSignInWithInvalidAccount_When_InAuthenticationPage()
        {
            
            var inValidEmail = "wrong@email.com";
            var inValidPassword = "wrong-pass";

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete
            _shoppingCartPage.ClickProceedToCheckoutButton();            
            _authenticationPage.EmailSignInTextBox.Clear();
            _authenticationPage.EmailSignInTextBox.SendKeys(inValidEmail);
            _authenticationPage.PasswordSignInTextBox.Clear();
            _authenticationPage.PasswordSignInTextBox.SendKeys(inValidPassword);
            _authenticationPage.ClickSignIn();

            _authenticationPage.AssertValidationMessage("Authentication failed.");
        }

        [Test]
        public void TryToSignInWithInvalidEmail_When_InAuthenticationPage()
        {

            var inValidEmail = "wrong";
            var inValidPassword = "wrong-pass";

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.EmailSignInTextBox.Clear();
            _authenticationPage.EmailSignInTextBox.SendKeys(inValidEmail);
            _authenticationPage.PasswordSignInTextBox.Clear();
            _authenticationPage.PasswordSignInTextBox.SendKeys(inValidPassword);
            _authenticationPage.ClickSignIn();

            _authenticationPage.AssertValidationMessage("Invalid email address.");
        }

        [Test]
        public void TryToSignInWithInvalidPassword_When_InAuthenticationPage()
        {

            var inValidEmail = "valid@email.com";
            var inValidPassword = "w";

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.EmailSignInTextBox.Clear();
            _authenticationPage.EmailSignInTextBox.SendKeys(inValidEmail);
            _authenticationPage.PasswordSignInTextBox.Clear();
            _authenticationPage.PasswordSignInTextBox.SendKeys(inValidPassword);
            _authenticationPage.ClickSignIn();

            _authenticationPage.AssertValidationMessage("Invalid password.");
        }

        [Test]
        public void CreateNewAccountWithInvalidEmailAddress_When_InAuthenticationPage()
        {
            var newEmail = "wrong--mail";           

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.EmailCreateAccountTextBox.Clear();
            _authenticationPage.EmailCreateAccountTextBox.SendKeys(newEmail);
            _authenticationPage.ClickCreateAccount();

            _authenticationPage.AssertValidationMessage("Invalid email address.");
        }

        [Test]
        public void CreateNewValidAccount_When_InAuthenticationPage()
        {
            var newEmail = GenerateNewRandomEmailOrPassword();
            var newPassword = GenerateNewRandomEmailOrPassword();
            var dateOfBirth = new Date(1981,7,20);
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
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete
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
        public void OpenForgotYourPasswordLink_When_SigningInFromAuthenticationPage()
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.ClickForgottenPasswordLink();

            _forgottenPasswordPage.AssertForgottenPasswordPageLoaded();
        }

        [Test]
        public void RetrievePasswordWithInvalidEmail_When_InForgottenPasswordPage()
        {
            var email = "wrong_mail@gmail.com";

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.ClickForgottenPasswordLink();
            _forgottenPasswordPage.EmailInputField.Clear();
            _forgottenPasswordPage.EmailInputField.SendKeys(email);
            _forgottenPasswordPage.ClickRetrievePasswordButton();

            _forgottenPasswordPage.AssertRetriveForgottenPasswordErrorMessage();
        }

        [Test]
        public void RetrievePasswordWithValidEmail_When_InForgottenPasswordPage()
        {
            var personalInfo = new PersonalInfo();
            var validEmail = personalInfo.ValidEmail;            

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.ClickForgottenPasswordLink();
            _forgottenPasswordPage.EmailInputField.Clear();
            _forgottenPasswordPage.EmailInputField.SendKeys(validEmail);
            _forgottenPasswordPage.ClickRetrievePasswordButton();

            _forgottenPasswordPage.AssertRetriveForgottenPasswordConfirmationMessage(validEmail);
        }

        // YourAddressesPage Tests - TODO
        // 1. Assert creating new address

        // ShippingPage Tests        
        [Test]
        public void ShippingCostIsTheRightAmountBeforePayment_When_InShippingPage()
        {
            var newEmail = GenerateNewRandomEmailOrPassword();
            var newPassword = GenerateNewRandomEmailOrPassword();
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
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete
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
        public void ReadTermsOfServiceLinkWorking_When_InShippingPage()
        {
            var newEmail = GenerateNewRandomEmailOrPassword();
            var newPassword = GenerateNewRandomEmailOrPassword();
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
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete
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
        public void AgreeToTermsErrorMessage_When_TryingToProceedToPaymentPageFromShippingPage()
        {
            var newEmail = GenerateNewRandomEmailOrPassword();
            var newPassword = GenerateNewRandomEmailOrPassword();
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
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete
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
        // PaymentPage Tests 
        [Test]
        public void PaymentPageLoadedCorrectly_When_ClickingProceedToCheckoutFromShippingPage()
        {
            var newEmail = GenerateNewRandomEmailOrPassword();
            var newPassword = GenerateNewRandomEmailOrPassword();
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
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete
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
        public void PayByBankWire_When_InPaymentPage()
        {
            var newEmail = GenerateNewRandomEmailOrPassword();
            var newPassword = GenerateNewRandomEmailOrPassword();
            var dateOfBirth = new Date(1981, 7, 20);
            var personalInfo = new PersonalInfo()
            {
                Title = "Mr.",
                FirstName = "Jimmy",
                LastName = "Fallon",                
                Password = newPassword,
                //DateOfBirth = dateOfBirth

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
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete
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
        public void PayByCheck_When_InPaymentPage()
        {
            var newEmail = GenerateNewRandomEmailOrPassword();
            var newPassword = GenerateNewRandomEmailOrPassword();
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
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete
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

        // OrderSummaryPage Tests
        [Test]
        public void OrderIsSuccesfullyCompleted()
        {
            var newEmail = GenerateNewRandomEmailOrPassword();
            var newPassword = GenerateNewRandomEmailOrPassword();
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
#pragma warning disable CS0612 // Type or member is obsolete
            _quickViewPage.ClickProceedToCheckoutButton();
#pragma warning restore CS0612 // Type or member is obsolete
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
            _orderSummaryPage.ClickConfirmOrderButton();

            _orderConfirmation.AssertOrderIsSuccessfullyCompleted();
        }

        // MyAccountPage Tests - TODO
        // 1.
    }
}