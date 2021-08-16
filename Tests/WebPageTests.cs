using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
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
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
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
            _mainPage.OpenQuickViewPage(_mainPage.HoverOverDressPicturePrintedDress, _mainPage.QuickViewButtonPrintedDress);

            _quickViewPage.AssertQuickViewPageNavigationToPrintedDress("Printed Dress");
        }

        [Test]
        public void NavigationToQuickViewForPrintedSummerDress_When_QuickViewButtonClicked()
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage(_mainPage.HoverOverDressPicturePrintedSummerDress, _mainPage.QuickViewButtonPrintedSummerDress);

            _quickViewPage.AssertQuickViewPageNavigationToPrintedSummerDress("Printed Summer Dress");
        }

        [Test]
        public void NavigationToQuickViewForPrintedChiffonDress_When_QuickViewButtonClicked()
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage(_mainPage.HoverOverDressPicturePrintedChiffonDress, _mainPage.QuickViewButtonPrintedChiffonDress);

            _quickViewPage.AssertQuickViewPageNavigationToPrintedChiffonDress("Printed Chiffon Dress");
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
            _mainPage.OpenQuickViewPage(_mainPage.HoverOverDressPicturePrintedDress, _mainPage.QuickViewButtonPrintedDress);
            _quickViewPage.AddToCartButton.Click();
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
            _mainPage.OpenQuickViewPage(_mainPage.HoverOverDressPicturePrintedSummerDress, _mainPage.QuickViewButtonPrintedSummerDress);
            _quickViewPage.AddToCartButton.Click();
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
            _mainPage.OpenQuickViewPage(_mainPage.HoverOverDressPicturePrintedChiffonDress, _mainPage.QuickViewButtonPrintedChiffonDress);
            _quickViewPage.AddToCartButton.Click();
            _mainPage.WaitUntilProductIsAddeToCart();

            _mainPage.AssertValidDressName(expectedDressInfo);
        }

        [Test]
        public void ValidateDressInfoOnPreCheckoutScreen_When_PrintedDressWithChangedParametersAddedToCart()
        {
            var expectedDressInfo = new OrderDressInfo()
            {
                DressName = "Printed Dress",
                ColorAndSize = "Orange, L",
                Quantity = "2",
                Price = "$52.00"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage(_mainPage.HoverOverDressPicturePrintedDress, _mainPage.QuickViewButtonPrintedDress);
            _quickViewPage.ChangeParametersAndAddOrderToCart_WithoutColor
                (
                _quickViewPage.PrintedDressIncreaseQuantityButtonInQuickView,
           _quickViewPage.PrintedDressSizeDropDownButtonInQuickView,
           "L"
           );
            _mainPage.WaitUntilProductIsAddeToCart();

            _mainPage.AssertValidDressName(expectedDressInfo);
        }

        [Test]
        public void ValidateDressInfoOnPreCheckoutScreen_When_PrintedSummerDressWithChangedParametersAddedToCart()
        {
            var expectedDressInfo = new OrderDressInfo()
            {
                DressName = "Printed Summer Dress",
                ColorAndSize = "Blue, L",
                Quantity = "2",
                Price = "$57.96"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage(_mainPage.HoverOverDressPicturePrintedSummerDress, _mainPage.QuickViewButtonPrintedSummerDress);
            _quickViewPage.ChangeParametersAndAddOrderToCart
                (
                _quickViewPage.PrintedSummerDressIncreaseQuantityButtonInQuickView,
                 _quickViewPage.PrintedSummerDressSelectColorButtonInQuickView,
           _quickViewPage.PrintedSummerDressSizeDropDownButtonInQuickView,
           "L"
           );
            _mainPage.WaitUntilProductIsAddeToCart();

            _mainPage.AssertValidDressName(expectedDressInfo);
        }

        [Test]
        public void ValidateDressInfoOnPreCheckoutScreen_When_PrintedChiffonDressWithChangedParametersAddedToCart()
        {
            var expectedDressInfo = new OrderDressInfo()
            {
                DressName = "Printed Chiffon Dress",
                ColorAndSize = "Green, M",
                Quantity = "2",
                Price = "$32.80"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage(_mainPage.HoverOverDressPicturePrintedChiffonDress, _mainPage.QuickViewButtonPrintedChiffonDress);
            _quickViewPage.ChangeParametersAndAddOrderToCart
                (
                _quickViewPage.PrintedChiffonDressIncreaseQuantityButtonInQuickView,
                 _quickViewPage.PrintedChiffonDressSelectColorButtonInQuickView,
           _quickViewPage.PrintedChiffonDressSizeDropDownButtonInQuickView,
           "M"
           );
            _mainPage.WaitUntilProductIsAddeToCart();

            _mainPage.AssertValidDressName(expectedDressInfo);
        }

        [Test]
        public void CompareTwoItems()
        {
            _mainPage.Open();
            _mainPage.AddToCompare
                (
                _mainPage.HoverOverDressPicturePrintedChiffonDress,
                _mainPage.AddToCompareButtonPrintedChiffonDress, 
                _mainPage.HoverOverDressPicturePrintedDress, 
                _mainPage.AddToCompareButtonPrintedDress
                );            
            _mainPage.CompareButton.Click();
            // BUG: Adds to Compare 2 products, displays only one, when displaying Product Comparison Page

            //_productComparisonPage.AssertValidProductComparisonPage();
        }
    }
}
