using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class QuickViewPage
    {     
        public IWebElement AddToCartButton => _driver.FindElement(By.XPath("//*[@id='add_to_cart']/button/span"));

        public IWebElement DressNameTextFieldInQuickView(string dressName)
        {
            return _driver.FindElement(By.XPath($"//h1[contains(text(),'{dressName}')]"));
        }

        public IWebElement IncreaseQuantityButton(string dressName)
        {
            return _driver.FindElement(By.XPath($"(//h1[contains(text(),'{dressName}')]//following::form//following::p//following::a/span)[2]"));
        }

        public IWebElement QuantityButtonInput() => _driver.FindElement(By.XPath("//input[@id='quantity_wanted']"));        

        public IWebElement SizeDropDownByName(string dressName)
        {
            return _driver.FindElement(By.XPath($"//h1[contains(text(),'{dressName}')]//following::form//following::p//following::div[@class='selector']//following::select"));
        }

        public IWebElement SelectColorByName(string dressName, string color)
        {
            return _driver.FindElement(By.XPath($"//h1[contains(text(),'{dressName}')]//following::form//following::p//following::ul//a[@name='{color}']"));
        }

        public IWebElement ProceedToCheckoutButton => _driver.FindElement(By.XPath("//a[@title='Proceed to checkout']"));
    }
}

