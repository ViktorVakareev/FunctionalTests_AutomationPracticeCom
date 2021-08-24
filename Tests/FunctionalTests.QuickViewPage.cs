using NUnit.Framework;
using System;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class FunctionalTests
    {
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
        [Obsolete]
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

            _mainPage.AssertValidDress(expectedDressInfo);
        }

    }
}
