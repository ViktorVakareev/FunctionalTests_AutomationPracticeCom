using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    [TestFixture]
    public class WebPageTests

    {
        private IWebDriver _driver;
        private MainPage _mainPage;
        private QuickViewPage _quickViewPage;
        private ProductComparisonPage _productComparisonPage;
        private ShoppingCartPage _shoppingCartPage;
        private AuthenticationPage _authenticationPage;
        private AddressesPage _addressesPage;
        private YourAddressesPage _yourAddressesPage;
        private ShippingPage _shippingCartPage;
        private PaymentPage _paymentPage;
        private ForgottenPasswordPage _forgottenPasswordPage;        
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
            _yourAddressesPage = new YourAddressesPage(_driver);
            _shippingCartPage = new ShippingPage(_driver);
            _paymentPage = new PaymentPage(_driver);
            _forgottenPasswordPage = new ForgottenPasswordPage(_driver);
            _myAccountPage = new MyAccountPage(_driver);
        }

        [TearDown]
        public void CleanUp()
        {
            _driver.Quit();
        }

        // MainPage and QuickViewPage Tests
        [Test]
        public void NavigationToQuickViewForPrintedDress_When_QuickViewButtonClicked()
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Dress");

            _quickViewPage.AssertQuickViewPageNavigationToProduct("Printed Dress");
        }

        [Test]
        public void NavigationToQuickViewForPrintedSummerDress_When_QuickViewButtonClicked()
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Summer Dress");

            _quickViewPage.AssertQuickViewPageNavigationToProduct("Printed Summer Dress");
        }

        [Test]
        public void NavigationToQuickViewForPrintedChiffonDress_When_QuickViewButtonClicked()
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");

            _quickViewPage.AssertQuickViewPageNavigationToProduct("Printed Chiffon Dress");
        }

        [Test]
        public void OpenShoppingCartPage_When_ClickingCheckoutButtonFromCart()
        {
            var expectedDressInfo = new OrderDressInfo()
            {
                DressName = "Printed Dress",
                Color = "Orange",
                Size = "L",
                Quantity = 3,
                Price = "$26.00"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Dress");
            _quickViewPage.ClickAddToCart();
            _mainPage.WaitUntilProductIsAddeToCart();
            _mainPage.ClickContinueShoppingButton();
            _mainPage.ClickCartCheckoutButton();

            _shoppingCartPage.AssertShoppingCartPageLoaded();
        }

        [Test]
        public void ValidateDressInfoOnPreCheckoutScreen_When_PrintedDressAddedToCart()
        {
            var expectedDressInfo = new OrderDressInfo()
            {
                DressName = "Printed Dress",
                Color = "Orange",
                Size = "S",
                Quantity = 1,
                Price = "$26.00"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Dress");
            _quickViewPage.ClickAddToCart();
            _mainPage.WaitUntilProductIsAddeToCart();

            _mainPage.AssertValidDress(expectedDressInfo);
        }

        [Test]
        public void ValidateDressInfoOnPreCheckoutScreen_When_PrintedSummerDressAddedToCart()
        {
            var expectedDressInfo = new OrderDressInfo()
            {
                DressName = "Printed Summer Dress",
                Color = "Yellow",
                Size = "S",
                Quantity = 1,
                Price = "$28.98"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Summer Dress");
            _quickViewPage.ClickAddToCart();
            _mainPage.WaitUntilProductIsAddeToCart();

            _mainPage.AssertValidDress(expectedDressInfo);
        }

        [Test]
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
            _mainPage.WaitUntilProductIsAddeToCart();

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
            _mainPage.ClickProceedToCheckoutButton();

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
            _mainPage.ClickProceedToCheckoutButton();

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
            _mainPage.ClickProceedToCheckoutButton();

            _shoppingCartPage.AssertCorrectProductAddedToShoppingCart(order);
        }

        // AuthenticationPage Tests - TODO
        // 1. Create account
        // 2. 
        // 3. 

        [Test]
        public void SignInWithValidRegistration_When_InAuthenticationPage()
        {
            var personalInfo = new PersonalInfo();
            var validEmail = personalInfo.ValidEmail;
            var validPassword = personalInfo.ValidPassword;

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
            _mainPage.ClickProceedToCheckoutButton();
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.ClickForgottenPasswordLink();
            _authenticationPage.EmailSignInTextBox.Clear();
            _authenticationPage.EmailSignInTextBox.SendKeys(validEmail); 
            _authenticationPage.PasswordSignInTextBox.Clear();
            _authenticationPage.PasswordSignInTextBox.SendKeys(validPassword);
            _authenticationPage.ClickSignIn();

            _myAccountPage.AssertMyAccountPageLoaded();
        }

        [Test]
        public void SignInWithInValidRegistration_When_InAuthenticationPage()
        {
            
            var inValidEmail = "wrong@email.com";
            var inValidPassword = "wrong-pass";

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
            _mainPage.ClickProceedToCheckoutButton();
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.ClickForgottenPasswordLink();
            _authenticationPage.EmailSignInTextBox.Clear();
            _authenticationPage.EmailSignInTextBox.SendKeys(inValidEmail);
            _authenticationPage.PasswordSignInTextBox.Clear();
            _authenticationPage.PasswordSignInTextBox.SendKeys(inValidPassword);
            _authenticationPage.ClickSignIn();

            _authenticationPage.AssertSignInErrorMessage();
        }

        // ForgottenPaswordPageTests
        [Test]
        public void OpenForgotYourPasswordLink_When_SigningInFromAuthenticationPage()
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
            _mainPage.ClickProceedToCheckoutButton();
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
            _mainPage.ClickProceedToCheckoutButton();
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
            _mainPage.ClickProceedToCheckoutButton();
            _shoppingCartPage.ClickProceedToCheckoutButton();
            _authenticationPage.ClickForgottenPasswordLink();
            _forgottenPasswordPage.EmailInputField.Clear();
            _forgottenPasswordPage.EmailInputField.SendKeys(validEmail);
            _forgottenPasswordPage.ClickRetrievePasswordButton();

            _forgottenPasswordPage.AssertRetriveForgottenPasswordConfirmationMessage(validEmail);
        }
        // CreateAccountPage Tests - TODO
        // 1. Create new account through objects of PersonalInfo and AdressesInfo

        // AddressesPage Tests - TODO
        // 1. Assert Delivery address info are correct -> (first+last) name, address, (city, state zip), country, mobile

        // YourAddressesPage Tests - TODO
        // 1. Assert creating new address

        // ShippingPage Tests - TODO
        // 1. Shipping cost is $2.00
        // 2. Read Terms Link opens
        // 3. Try proceed to checkout without clicking Agree to terms

        // PaymentPage Tests - TODO
        // 1. 

        // MyAccountPage Tests - TODO
        // 1.


    }
}
