﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FunctionalTests_AutomationPracticeCom
{
    [TestFixture]
    public class WebPageTests

    {
        private IWebDriver _driver;
        private MainPage _mainPage;
        private QuickViewPage _quickViewPage;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _mainPage = new MainPage(_driver);
            _quickViewPage = new QuickViewPage(_driver);
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

            _mainPage.AssertValidDressName(expectedDressInfo);
        }
            // TODO Change Order Parameters ANd Assert If Valid On Pre-Checkout    
    }
}
