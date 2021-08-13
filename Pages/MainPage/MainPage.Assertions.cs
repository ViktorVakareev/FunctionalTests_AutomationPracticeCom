using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class MainPage
    {

        public void AssertValidDressName(OrderDressInfo expectedDressInfo)
        {
            Assert.AreEqual(expectedDressInfo.DressName, DressNameBeforeCheckout.Text);
            Assert.AreEqual(expectedDressInfo.Quantity, DressQuantityBeforeCheckout.Text);
            Assert.AreEqual(expectedDressInfo.ColorAndSize, DressColorAndSizeBeforeCheckout.Text);
            Assert.AreEqual(expectedDressInfo.Price, DressPriceBeforeCheckout.Text);
        }
        //TODO assertions through OrderDressInfo(Dto) class =>
        //AssertValidDressQuantity(Order string DressName, string Color, string Size, int Quantity)

        //public void AssertValidDressName_When_AddingToCartInQuickView()
        //{
        //    Assert.AreEqual("Printed Dress", DressNameBeforeCheckout.Text);
        //}

        //public void AssertValidDressPrice_When_AddingToCartInQuickView()
        //{
        //    Assert.AreEqual("$26.00", DressPriceBeforeCheckout.Text);
        //}
        //public void AssertValidationMessageForAddingToCart_When_AddingToCartInQuickView()
        //{
        //    Assert.AreEqual("Product successfully added to your shopping cart ", ProductSuccesfullyAdded.ToString());
        //}

        //public void AssertValidDressColorAndSize_When_AddedToCart_AfterChangingOrderParameters()
        //{
        //    Assert.AreEqual("Pink, M", DressSizeAndColorBeforeCheckout.Text);
        //}

        //public void AssertValidDressQuantity_When_AddedToCart_AfterChangingOrderParameters()
        //{
        //    Assert.AreEqual("2", DressQuantityBeforeCheckout.Text);
        //}

        //public void AssertValidDressPrice_When_AddedToCart_AfterChangingOrderParameters()
        //{
        //    Assert.AreEqual("$101.98", DressPriceBeforeCheckout.Text);
        //}
    }
}
