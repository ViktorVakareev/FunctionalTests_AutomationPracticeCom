using NUnit.Framework;
using System;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class FunctionalTests
    {
        [Test]
        [Obsolete]
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
        public void CorrectMessageDisplayed_When_ViewMyShoppingCartLinkClickedInMainPage()
        {
            _mainPage.Open();
            _mainPage.ClickViewMyShoppingCartButton();

            _shoppingCartPage.AssertEmptyShoppingCartMessageDisplayed();
        }

        [Test]
        [Obsolete]
        public void ShoppingCartPageLoadedCorrectly_When_ProductAddedToCartFromQuickView()
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
            _quickViewPage.ClickProceedToCheckoutButton();

            _shoppingCartPage.AssertShoppingCartPageLoaded();
        }

        [Test]
        [Obsolete]
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
            _quickViewPage.ClickProceedToCheckoutButton();

            _shoppingCartPage.AssertCorrectTotalPriceInShoppingCart(order);
        }

        [Test]
        [Obsolete]
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
            _quickViewPage.ClickProceedToCheckoutButton();

            _shoppingCartPage.AssertCorrectProductAddedToShoppingCart(order);
        }
    }
}


