using NUnit.Framework;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ShoppingCartPage
    {
        public ShoppingCartPage()
        {
        }

        public void AssertComparisonPageLoaded()
        {
            Assert.AreEqual("SHOPPING-CART SUMMARY", ShoppingCartPageHeading.Text);
        }

        public void AssertCorrectProductAddedToShoppingCart(OrderDressInfo order)
        {
            // TODO
        }

        public void AssertCorrectTotalPriceInShoppingCart()
        {
            // TODO
        }

    }
}
