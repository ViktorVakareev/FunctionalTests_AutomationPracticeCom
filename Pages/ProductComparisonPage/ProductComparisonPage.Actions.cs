using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ProductComparisonPage : BasePage
    {
        public override string Url => "http://automationpractice.com/index.php?id_category=8&controller=category";

        public ProductComparisonPage(IWebDriver driver) 
            : base(driver)
        { 
        }            
    }
}
