using NUnit.Framework;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class QuickViewPage
    {
        public QuickViewPage()
        {
        }
             public void AssertQuickViewPageNavigationToProduct(string dressName)
        {
            Assert.AreEqual(dressName, DressNameTextFieldInQuickView(dressName).Text);
        }
  
    }
}
