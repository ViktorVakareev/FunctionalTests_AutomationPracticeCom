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
        WebDriverWait wait;

        public string Url => "http://automationpractice.com/index.php?id_category=8&controller=category";

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
            _actions = new Actions(driver);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        public void Open()
        {
            _driver.Navigate().GoToUrl(Url);
        }

        public void OpenQuickViewPage(string dressName)
        {
          _actions.MoveToElement(HoverDressByName(dressName))
                  .MoveToElement(QuickViewButtonDressByName(dressName))
                  .Click()
                  .Perform();

            _driver.SwitchTo().Frame(QuickViewIframeWindow);
        }

        public void OpenQuickViewPage(string dressName, string type)
        {
          _actions.MoveToElement(HoverDressByName(dressName, type))
                  .MoveToElement(QuickViewButtonDressByName(dressName))
                  .Click()
                  .Perform();

            _driver.SwitchTo().Frame(QuickViewIframeWindow);
        }

        public void AddToCompare(string dressName, int productId)
        {
          _actions.MoveToElement(HoverDressByName(dressName))                                  
                  .MoveToElement(AddToCompareButtonDressByName(dressName, productId))
                  .Click()
                  .Perform();
        }
        public void AddToCompare(string dressName, int productId, string type)
        {
          _actions.MoveToElement(HoverDressByName(dressName, type))
                  .MoveToElement(AddToCompareButtonDressByName(dressName, productId))
                  .Click()
                  .Perform();           
        }

        public void CompareItems()
        {
            Thread.Sleep(3000);
            CompareButton.Click();
        }
        public void ReturnToMainPage()
        {
            _driver.SwitchTo().DefaultContent();
        }

        public void WaitUntilProductIsAddeToCart()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(ValidationMessageForSuccessfullyAddedToCart));
        }

        public void WaitUntilCompareButton()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(ValidationMessageForSuccessfullyAddedToCart));
        }
    }
}
