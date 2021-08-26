using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ShoppingCartPage
    {
        public void AssertEmptyShoppingCartMessageDisplayed()
        {            
            Assert.AreEqual("Your shopping cart is empty.", EmptyCartMessage.Text);
            Assert.AreEqual("http://automationpractice.com/index.php?controller=order", _driver.Url);
        }

        public void AssertShoppingCartPageLoaded()
        {
            StringAssert.Contains("SHOPPING-CART SUMMARY", ShoppingCartPageHeading.Text);
            Assert.AreEqual("http://automationpractice.com/index.php?controller=order", _driver.Url);
        }

        public void AssertCorrectProductAddedToShoppingCart(OrderDressInfo expectedOrder)
        {
            var expectedUnitPrice = ConvertUnitPriceToString(expectedOrder);           
            var actualColor = ExtractColorFromColorAndSizeField(ColorAndSizeField);   
            var actualSize = ExtractSizeFromColorAndSizeField(ColorAndSizeField);  

            Assert.AreEqual(expectedOrder.DressName, DressNameField.Text);
            Assert.AreEqual(expectedUnitPrice, UnitPriceField.Text);
            Assert.AreEqual(expectedOrder.Color, actualColor);
            Assert.AreEqual(expectedOrder.Size, actualSize);
        }

        public void AssertCorrectTotalPriceInShoppingCart(OrderDressInfo expectedOrder)
        {
            int totalShippingCost = Int32.Parse(expectedOrder.DeliveryPrice.Substring(1, 1));
            var totalPrice = double.Parse(expectedOrder.Price.Substring(1)) + totalShippingCost;
            var expectedTotalPrice = "$" + $"{totalPrice}" + "0";

            Assert.AreEqual(expectedTotalPrice, TotalPriceField.Text);
        }

        private string ConvertUnitPriceToString(OrderDressInfo orderInfo)   
        {
            var totalPrice = double.Parse(orderInfo.Price.Substring(1));
            var unitPrice = "$" + $"{(totalPrice / orderInfo.Quantity):0.00}";
            return unitPrice;
        }

        private string ExtractColorFromColorAndSizeField(IWebElement ColorAndSizeField)    // Color : Beige, Size : S
        {              
            string element = ColorAndSizeField.Text.Split(", ")[0];
            string color = element.Split(": ")[1];
            return color;
        }

        private string ExtractSizeFromColorAndSizeField(IWebElement ColorAndSizeField)
        {
            string element = ColorAndSizeField.Text.Split(", ")[1];
            string size = element.Split(": ")[1];
            return size;
        }
    }
}
