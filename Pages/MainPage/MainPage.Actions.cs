using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public void CompareItems(IWebElement hoverElement1, IWebElement quickViewElement1, IWebElement hoverElement2, IWebElement quickViewElement2)
        {
            // Click First item Add to Compare button
            _actions.MoveToElement(hoverElement1).MoveToElement(quickViewElement1)
               .Click()
               .Perform();

            // Click Second item Add to Compare button
            _actions.MoveToElement(hoverElement1).MoveToElement(quickViewElement1)
                .Click()
                .Perform();
        }

        public void ReturnToMainPage_When_InQuickView()
        {
            _driver.SwitchTo().DefaultContent();
        }
    }
}
