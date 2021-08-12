using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class QuickViewPage
    {
        public QuickViewPage()
        {
        }

        public void AssertValidDressName_When_EnteringQuickView()
        {
            Assert.AreEqual("Printed Dress", DressName.Text);
        }
        public void AssertValidDressQuantity_When_EnteringQuickView()
        {
            Assert.AreEqual("1", QuantityTextBox.Text);
        }

        public void AssertValidDressPrice_When_EnteringQuickView()
        {
            Assert.AreEqual("$26.00", DressPrice.Text);
        }

        public void AssertValidDressSize_When_EnteringQuickView()
        {
            Assert.AreEqual("S", SizeDropDown.Text);
        }

        public void AssertValidDressInfoText_When_EnteringQuickView()
        {
            Assert.AreEqual("100% cotton double printed dress. Black and white striped top and orange high waisted skater skirt bottom.", DressInfoText.Text);
        }

        public void AssertValidDressQuantity_When_AddingToCartInQuickView()
        {
            Assert.AreEqual("1", DressName.Text);
        }

        public void AssertValidDressName_When_AddingToCartInQuickView()
        {
            Assert.AreEqual("Printed Dress", DressName.Text);
        }

        public void AssertValidDressPrice_When_AddingToCartInQuickView()
        {
            Assert.AreEqual("$26.00", DressPrice.Text);
        }
        
        public void AssertValidationMessageForAddingToCart_When_AddingToCartInQuickView()
        {
            Assert.AreEqual("Product successfully added to your shopping cart", ProductSuccesfullyAdded.Text);
        }

        public void AssertValidDressColorAndSize_When_AddedToCart()
        {
            Assert.AreEqual("Pink, M", DressSizeAndColorBeforeCheckout.Text);
        }             

        public void AssertValidDressQuantity_When_AddedToCart()
        {
            Assert.AreEqual("2", DressQuantityBeforeCheckout.Text);
        }

        public void AssertValidDressPrice_When_AddedToCart()
        {
            Assert.AreEqual("$101.98", DressPriceBeforeCheckout.Text);
        }
    }
}
