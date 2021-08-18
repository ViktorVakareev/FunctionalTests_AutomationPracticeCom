using NUnit.Framework;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ShoppingCartPage
    {
        //public ShoppingCartPage()
        //{
        //}

        public void AssertShppoingCartPageLoaded()
        {
            Assert.AreEqual("SHOPPING-CART SUMMARY", ShoppingCartPageHeading.Text);
            Assert.AreEqual("http://automationpractice.com/index.php?controller=order", _driver.Url);

        }

        public void AssertCorrectProductAddedToShoppingCart(OrderDressInfo order)
        {
            // TODO
        }

        public void AssertCorrectTotalPriceInShoppingCart(OrderDressInfo expectedOrder)
        {
            int totalShippingCost = 2;
            var totalPrice = double.Parse(expectedOrder.Price.Substring(1)) + totalShippingCost;            
            var expectedTotalPrice = "$" + $"{totalPrice}" + "0";

            Assert.AreEqual(expectedTotalPrice, TotalPriceField.Text);
        }

    }
}
