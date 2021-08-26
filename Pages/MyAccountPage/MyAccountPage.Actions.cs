using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class MyAccountPage : BasePage
    {
        public override string Url => "http://automationpractice.com/index.php?controller=my-account";

        public MyAccountPage(IWebDriver driver) 
            : base(driver)
        {        
        }       
    }
}
