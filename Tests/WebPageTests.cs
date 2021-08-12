using NUnit.Framework;
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
        private ChromeOptions _options;

        [SetUp]
        public void Setup()
        {
            _options = new ChromeOptions();
            _options.AddArgument("--start-maximized");
            _driver = new ChromeDriver(_options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            _mainPage = new MainPage(_driver);
            _quickViewPage = new QuickViewPage(_driver);
        }

        [TearDown]
        public void CleanUp()
        {
            _driver.Quit();
        }

        [Test]
        public void NavigationToQuickViewMenu_When_QuickViewButtonClicked()
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage(_mainPage.HoverOverDressPictureFirstItem, _mainPage.QuickViewButtonFirstItem);

            _quickViewPage.AssertValidDressName_When_EnteringQuickView();            
        }

        [Test]
        public void ValidateDressInformation_When_QuickViewButtonClicked()
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage(_mainPage.HoverOverDressPictureFirstItem, _mainPage.QuickViewButtonFirstItem);                        
            
            _quickViewPage.AssertValidDressPrice_When_EnteringQuickView();
            _quickViewPage.AssertValidDressInfoText_When_EnteringQuickView();
            _quickViewPage.AssertValidDressSize_When_EnteringQuickView();
        }

        [Test]
        public void AddCorrectItemInCart_When_AddToCartButtonClicked()
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage(_mainPage.HoverOverDressPictureFirstItem, _mainPage.QuickViewButtonFirstItem);

            _quickViewPage.AssertValidDressQuantity_When_AddingToCartInQuickView();
            _quickViewPage.AssertValidDressName_When_AddingToCartInQuickView();
            _quickViewPage.AssertValidDressPrice_When_AddingToCartInQuickView();
            _quickViewPage.AssertValidationMessageForAddingToCart_When_AddingToCartInQuickView();
        }

        [Test]
        public void ChangeQuantityAndAddToCart_When_InQuickViewMenu()
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage(_mainPage.HoverOverDressPictureSecondItem, _mainPage.QuickViewButtonSecondItem);
            _quickViewPage.QuantityTextBox.Clear();
            _quickViewPage.QuantityTextBox.SendKeys("2");   
            _quickViewPage.AddNewProductToCart();

            _quickViewPage.AssertValidDressQuantity_When_AddedToCart();
        }

        [Test]
        public void ChangeColorAndSizeAndAddToCart_When_InQuickViewMenu()
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage(_mainPage.HoverOverDressPictureSecondItem, _mainPage.QuickViewButtonSecondItem);
            // Change color
            //_quickViewPage.ColorSelectButton.Click();
            //_quickViewPage.ColorSelectButton.SendKeys(Keys.Tab);
            //_quickViewPage.ColorSelectButton.SendKeys(Keys.Enter);
            // Change size
            _quickViewPage.SizeDropDown.Click();
            _quickViewPage.SizeDropDown.SendKeys("M");
            _quickViewPage.SizeDropDown.SendKeys(Keys.Enter);
            // Add to cart  
            _quickViewPage.AddNewProductToCart();

            _quickViewPage.AssertValidDressColorAndSize_When_AddedToCart();
        }

        [Test]
        public void ChangeQuantityAndAddToCart_When_InQuickViewMenu_CheckPrice()
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage(_mainPage.HoverOverDressPictureSecondItem, _mainPage.QuickViewButtonSecondItem);
            _quickViewPage.QuantityTextBox.Clear();
            _quickViewPage.QuantityTextBox.SendKeys("2");
            _quickViewPage.AddNewProductToCart();

            _quickViewPage.AssertValidDressPrice_When_AddedToCart();
        }

        //[Test]
        //public void VerifyCorrectProductAdded_When_AddToCartButtonClicked()
        //{
        //    _mainPage.Open();
        //    _mainPage.OpenQuickViewPage(_mainPage.HoverOverDressPictureFirstItem, _mainPage.QuickViewButtonFirstItem);

        //    _quickViewPage.AddNewProductToCart();
        //}
    }
}
