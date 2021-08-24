using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

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
            _driver.Close();
        }       
    }
}
