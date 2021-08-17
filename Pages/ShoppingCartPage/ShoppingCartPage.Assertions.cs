using NUnit.Framework;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ShoppingCartPage
    {
        public ProductComparisonPage()
        {
        }

        public void AssertComparisonPageLoaded()
        {
            Assert.AreEqual("PRODUCT COMPARISON", ComparisonPageHeading.Text);
        }

        public void AssertCorrectProductAddedToProductComparisonPage(List<OrderDressInfo> dressesToCompare)
        {
            for (int i = 0; i < dressesToCompare.Count; i++)
            {
                string currentDressName = dressesToCompare[i].DressName;
                string currentDressPrice = dressesToCompare[i].Price;

                Assert.AreEqual(currentDressPrice, DressPriceField(currentDressName).Text);
                Assert.AreEqual(currentDressName, DressNameField(currentDressName).Text);                
            }
        }
    }
}
