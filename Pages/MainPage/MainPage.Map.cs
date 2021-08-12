using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class MainPage
    {
        public MainPage()
        {
        }

        public IWebElement CompareButton => _driver.FindElement(By.XPath("//form[@class='compare-form']/button[@type='submit']"));

        public IWebElement MoreButton => _driver.FindElement(By.XPath("//a/span[text()='More']"));

        public IWebElement AddToCompareButtonFirstItem => _driver.FindElement(By.XPath("(//a[@class='add_to_compare'])[1]"));

        public IWebElement AddToCompareButtonSecondItem => _driver.FindElement(By.XPath("(//a[@class='add_to_compare'])[2]"));

        public IWebElement QuickViewButtonFirstItem => _driver.FindElement(By.XPath("(//a[@class='quick-view']/span)[1]"));

        public IWebElement QuickViewButtonSecondItem => _driver.FindElement(By.XPath("(//a[@class='quick-view']/span)[2]"));

        public IWebElement HoverOverDressPictureFirstItem => _driver.FindElement(By.XPath("(//img[@title='Printed Dress'])[1]"));

        public IWebElement HoverOverDressPictureSecondItem => _driver.FindElement(By.XPath("(//img[@title='Printed Dress'])[2]"));

        public IWebElement QuickViewIframeWindow => _driver.FindElement(By.XPath("//iframe[@class='fancybox-iframe']"));

        public IWebElement ContinueShoppingButton => _driver.FindElement(By.XPath("//span[@title='Continue shopping']"));
    }
}
