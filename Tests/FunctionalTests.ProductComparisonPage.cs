using NUnit.Framework;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class FunctionalTests
    {
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
    }
}
