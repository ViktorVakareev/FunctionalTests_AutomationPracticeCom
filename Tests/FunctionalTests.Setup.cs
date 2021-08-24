using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager.DriverConfigs.Impl;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class FunctionalTests
    {
        private ChromeDriver _driver;
        private MainPage _mainPage;
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
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
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

        [OneTimeTearDown]
        public void CleanUp()
        {
            if (_driver != null)
            {                
                _driver.Dispose();
            }
        }
    }
}
