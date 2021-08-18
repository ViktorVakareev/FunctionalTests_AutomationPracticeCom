using NUnit.Framework;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class QuickViewPage
    {
        //public QuickViewPage()
        //{
        //}
             public void AssertQuickViewPageNavigationToProduct(string expectedDressName)
        {
            Assert.AreEqual(expectedDressName, DressNameTextFieldInQuickView(expectedDressName).Text);
        }
  
    }
}
