using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class MainPage
    {
        private IWebDriver _driver;
        private Actions _actions;

        public string Url => "http://automationpractice.com/index.php?id_category=8&controller=category";

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
            _actions = new Actions(driver);
        }

        public void Open()
        {
            _driver.Navigate().GoToUrl(Url);
        }

        public void OpenQuickViewPage(IWebElement hoverElement, IWebElement quickViewElement)
        {          
            _actions.MoveToElement(hoverElement).MoveToElement(quickViewElement)
                .Click()
                .Perform();

            _driver.SwitchTo().Frame(QuickViewIframeWindow);
        }

        public void AddToCompare(IWebElement hoverElement1, IWebElement addToCompare1, IWebElement hoverElement2, IWebElement addToCompare2)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // Click First item Add to Compare button            
            _actions.MoveToElement(hoverElement1).MoveToElement(addToCompare1)
                .Click()
                .Perform();

            // Click Second item Add to Compare button
            _actions.MoveToElement(hoverElement2).MoveToElement(addToCompare2)
                .Click()
                .Perform();            
        }              

        public void ReturnToMainPage()
        {
            _driver.SwitchTo().DefaultContent();
        }

        public void WaitUntilProductIsAddeToCart()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//i[@class='icon-ok']")));
        }

        public void WaitUntilCompareButtonClickable()
        {
            var element = CompareButton;
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.TextToBePresentInElementValue(CompareButton, "2"));
        }
    }
}
