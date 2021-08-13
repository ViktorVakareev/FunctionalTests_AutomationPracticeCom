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
        public IWebElement PrintedDressNameTextFieldInQuickView => _driver.FindElement(By.XPath("//h1[contains(text(),'Printed Dress')]"));

        public IWebElement PrintedSummerDressNameTextFieldInQuickView => _driver.FindElement(By.XPath("//h1[contains(text(),'Printed Summer Dress')]"));

        public IWebElement PrintedChiffonDressNameTextFieldInQuickView => _driver.FindElement(By.XPath("//h1[contains(text(),'Printed Chiffon Dress')]"));

        public IWebElement AddToCartButton => _driver.FindElement(By.XPath("//*[@id='add_to_cart']/button/span"));
    }
}
