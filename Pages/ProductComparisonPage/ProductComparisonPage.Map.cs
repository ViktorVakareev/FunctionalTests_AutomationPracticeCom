using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ProductComparisonPage
    {
        public IWebElement ComparisonPageHeading => _driver.FindElement(By.ClassName("page-heading"));

        public IWebElement ContinueShoppingButton => _driver.FindElement(By.XPath("//span[@title='Continue shopping']/span"));

        public IWebElement DressNameField(string dressName)
        {
            return _driver.FindElement(By.XPath($"//h5/a[@title='{dressName}']"));
        }

        public IWebElement DressPriceField(string dressName)
        {
            return _driver.FindElement(By.XPath($"(//h5/a[@title='{dressName}']//following::span[@class='price product-price'])[1]"));
        }
    }
}

