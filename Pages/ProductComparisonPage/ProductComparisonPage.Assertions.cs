using NUnit.Framework;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ProductComparisonPage
    {
        public void AssertComparisonPageLoaded()
        {
            Assert.AreEqual("PRODUCT COMPARISON", ComparisonPageHeading.Text);
        }

        public void AssertCorrectProductAddedToProductComparisonPage(List<OrderDressInfo> dressesToCompare)
        {           
            foreach (var dress in dressesToCompare)
            {
                string expectedCurrentDressName = dress.DressName;
                string expectedCurrentDressPrice = dress.Price;

                Assert.AreEqual(expectedCurrentDressPrice, DressPriceField(expectedCurrentDressName).Text);
                Assert.AreEqual(expectedCurrentDressName, DressNameField(expectedCurrentDressName).Text);
            }            
        }
    }
}
