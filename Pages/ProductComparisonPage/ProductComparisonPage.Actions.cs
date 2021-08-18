using FunctionalTests_AutomationPracticeCom.Pages;
using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ProductComparisonPage : BasePage
    {  
        public string Url => "http://automationpractice.com/index.php?controller=products-comparison";

        public ProductComparisonPage(IWebDriver driver) : base(driver)
        { 
        }
            
        public void Open()
        {
            _driver.Navigate().GoToUrl(Url);
        }
    }
}
