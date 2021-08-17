using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

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

        public void CompareButtonClick()
        {
            WaitUntilCompareButtonClickable(CompareButtonLocator);
            CompareButton.Click();
        }

        public void ProceedToCheckoutButtonClick()
        {
            ProceedToCheckoutButton.Click();
        }

        public void ReturnToMainPage()
        {
            _driver.SwitchTo().DefaultContent();
        }

        public void WaitUntilProductIsAddeToCart()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(ValidationMessageForSuccessfullyAddedToCart));
        }

        public void WaitUntilCompareButtonClickable(By locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(CompareButtonLocator));
        }
    }
}
