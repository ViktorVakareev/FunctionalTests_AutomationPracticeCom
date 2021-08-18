using NUnit.Framework;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class MainPage
    {

        public void AssertValidDress(OrderDressInfo expectedDressInfo)
        {
            var expectedColorAndSize = $"{expectedDressInfo.Color}, {expectedDressInfo.Size}";

            Assert.AreEqual(expectedDressInfo.DressName, DressNameBeforeCheckout.Text);
            Assert.AreEqual(expectedDressInfo.Quantity.ToString(), DressQuantityBeforeCheckout.Text);
            Assert.AreEqual(expectedColorAndSize, DressColorAndSizeBeforeCheckout.Text);
            Assert.AreEqual(expectedDressInfo.Price, DressPriceBeforeCheckout.Text);
        }

        public void AssertProductComparisonErrorMessage()
        {
            Assert.AreEqual("You cannot add more than 3 product(s) to the product comparison", ErrorMessageProductComparison.Text);
        }
    }
}
