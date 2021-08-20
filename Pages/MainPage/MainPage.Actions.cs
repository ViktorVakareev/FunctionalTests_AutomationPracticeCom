using FunctionalTests_AutomationPracticeCom.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class MainPage : BasePage
    {        
        private Actions _actions;
        private WebDriverWait _wait;

        public override string Url => "http://automationpractice.com/index.php?id_category=8&controller=category";        

        public MainPage(IWebDriver driver) : base(driver)
        {            
            _actions = new Actions(driver);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        public void OpenQuickViewPage(string dressName)
        {
            _actions.MoveToElement(HoverDressByNameSpan(dressName))
                    .MoveToElement(QuickViewButtonDressByName(dressName))
                    .Click()
                    .Perform();

            _driver.SwitchTo().Frame(QuickViewIframeWindow);
        }

        public void OpenQuickViewPage(string dressName, string type)
        {
            _actions.MoveToElement(HoverDressByNameSpan(dressName, type))
                    .MoveToElement(QuickViewButtonDressByName(dressName))
                    .Click()
                    .Perform();

            _driver.SwitchTo().Frame(QuickViewIframeWindow);
        }

        public void AddToCompare(string dressName, int productId)
        {
            _actions.MoveToElement(HoverDressByNameSpan(dressName))
                    .MoveToElement(AddToCompareButtonDressByName(dressName, productId))
                    .Click()
                    .Perform();
        }
        public void AddToCompare(string dressName, int productId, string type)
        {
            _actions.MoveToElement(HoverDressByNameSpan(dressName, type))
                    .MoveToElement(AddToCompareButtonDressByName(dressName, productId))
                    .Click()
                    .Perform();
        }

        public void ClickCartCheckoutButton()
        {
            ViewMyShoppingCartLink.Click();           
        }

        public void CompareButtonClick()
        {
            var elementToClick = 
            _wait.Until(ExpectedConditions.ElementToBeClickable(CompareButtonLocator));
            CompareButton.Click();
        }
        
        public void ClickProceedToCheckoutButton() => ProceedToCheckoutButton.Click();

        public void ClickContinueShoppingButton() => ContinueShoppingButton.Click(); 
        
        public void ClickViewMyShoppingCartButton() => ViewMyShoppingCartLink.Click();

        public void WaitUntilProductIsAddeToCart() => _wait.Until(ExpectedConditions.ElementIsVisible(ValidationMessageForSuccessfullyAddedToCart));        
    }
}
