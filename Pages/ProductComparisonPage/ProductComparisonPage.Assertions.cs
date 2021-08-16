using NUnit.Framework;
using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ProductComparisonPage
    {
        public ProductComparisonPage()
        {
        }
        public void AssertValidProductComparisonPage()
        {
            Assert.AreEqual("http://automationpractice.com/index.php?controller=products-comparison&compare_product_list=3%7C7", _driver.Url);
        }
    }
}
