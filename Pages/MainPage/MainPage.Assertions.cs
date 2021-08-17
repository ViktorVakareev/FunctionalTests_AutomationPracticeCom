using NUnit.Framework;

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

        public void AssertProductComparisonErrorMessage()
        {
            Assert.AreEqual("You cannot add more than 3 product(s) to the product comparison", ErrorMessageProductComparison.Text);
        }
    }
}
