using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace FunctionalTests_AutomationPracticeCom
{
    [TestFixture]
    public class WebPageTests

    {
        private IWebDriver _driver;
        private MainPage _mainPage;
        private QuickViewPage _quickViewPage;
        private ProductComparisonPage _productComparisonPage;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            _driver.Manage().Window.Maximize();
            _mainPage = new MainPage(_driver);
            _quickViewPage = new QuickViewPage(_driver);
            _productComparisonPage = new ProductComparisonPage(_driver);
        }

        [TearDown]
        public void CleanUp()
        {
            _driver.Quit();
        }

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
        public void ValidateDressInfoOnPreCheckoutScreen_When_PrintedDressAddedToCart()
        {
            var expectedDressInfo = new OrderDressInfo()
            {
                DressName = "Printed Dress",
                ColorAndSize = "Orange, S",
                Quantity = "1",
                Price = "$26.00"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Dress");
            _quickViewPage.ClickAddToCart();
            _mainPage.WaitUntilProductIsAddeToCart();

            _mainPage.AssertValidDressName(expectedDressInfo);
        }

        [Test]
        public void ValidateDressInfoOnPreCheckoutScreen_When_PrintedSummerDressAddedToCart()
        {
            var expectedDressInfo = new OrderDressInfo()
            {
                DressName = "Printed Summer Dress",
                ColorAndSize = "Yellow, S",
                Quantity = "1",
                Price = "$28.98"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Summer Dress");
            _quickViewPage.ClickAddToCart();
            _mainPage.WaitUntilProductIsAddeToCart();

            _mainPage.AssertValidDressName(expectedDressInfo);
        }

        [Test]
        public void ValidateDressInfoOnPreCheckoutScreen_When_PrintedChiffonDressAddedToCart()
        {
            var expectedDressInfo = new OrderDressInfo()
            {
                DressName = "Printed Chiffon Dress",
                ColorAndSize = "Yellow, S",
                Quantity = "1",
                Price = "$16.40"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.AddToCartButton.Click();
            _mainPage.WaitUntilProductIsAddeToCart();

            _mainPage.AssertValidDressName(expectedDressInfo);
        }

        [Test]
        public void ValidateDressInfoOnPreCheckoutScreen_When_PrintedDressWithChangedParametersAddedToCart()
        {
            var order = new OrderDressInfo()
            {
                DressName = "Printed Dress",
                ColorAndSize = "Orange, L",
                Quantity = "2",
                Price = "$52.00"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Dress");
            _quickViewPage.AddOrderToCart(order);
            _mainPage.WaitUntilProductIsAddeToCart();

            _mainPage.AssertValidDressName(order);
        }

        [Test]
        public void ValidateDressInfoOnPreCheckoutScreen_When_PrintedSummerDressWithChangedParametersAddedToCart()
        {
            var order = new OrderDressInfo()
            {
                DressName = "Printed Summer Dress",
                ColorAndSize = "Blue, L",
                Quantity = "2",
                Price = "$57.96"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Summer Dress");
            _quickViewPage.AddOrderToCart(order);
            _mainPage.WaitUntilProductIsAddeToCart();

            _mainPage.AssertValidDressName(order);
        }

        [Test]
        public void ValidateDressInfoOnPreCheckoutScreen_When_PrintedChiffonDressWithChangedParametersAddedToCart()
        {
            var order = new OrderDressInfo()
            {
                DressName = "Printed Chiffon Dress",
                ColorAndSize = "Green, M",
                Quantity = "6",
                Price = "$98.40"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.AddOrderToCart(order);
            _mainPage.WaitUntilProductIsAddeToCart();

            _mainPage.AssertValidDressName(order);
        }

        [Test]
        public void CorrectProductsAreCompared_When_ProductComparisonPageLoaded()
        {
            var dressesToCompare = new List<OrderDressInfo>();
            var dress1 = new OrderDressInfo()
            {
                DressName = "Printed Chiffon Dress",
                ColorAndSize = "Yellow, S",
                Quantity = "1",
                Price = "$16.40"
            };            
            var dress2 = new OrderDressInfo()
            {
                DressName = "Printed Summer Dress",
                ColorAndSize = "Yellow, S",
                Quantity = "1",
                Price = "$28.98"
            };
            dressesToCompare.Add(dress1);
            dressesToCompare.Add(dress2);

            _mainPage.Open();
            _mainPage.AddToCompare("Printed Summer Dress", 5);            
            _mainPage.AddToCompare("Printed Chiffon Dress", 7);
            _mainPage.CompareItems();

            _productComparisonPage.AssertCorrectProductAddedToProductComparisonPage(dressesToCompare);
        }

        [Test]
        public void ProductComparisonPageLoaded_When_ProductsAddedToCompare()
        {
            _mainPage.Open();
            _mainPage.AddToCompare("Printed Summer Dress", 5);            
            _mainPage.AddToCompare("Printed Chiffon Dress", 7);            
            _mainPage.CompareItems();

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
            _mainPage.CompareItems();

            _mainPage.AssertProductComparisonErrorMessage();
        }
    }
}
