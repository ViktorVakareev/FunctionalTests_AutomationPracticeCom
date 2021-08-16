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

        public IWebElement QuickViewIframeWindow => _driver.FindElement(By.XPath("//iframe[@class='fancybox-iframe']"));

        public IWebElement CompareButton => _driver.FindElement(By.XPath("//form[@class='compare-form']/button[@type='submit']"));       

        public IWebElement DressNameBeforeCheckout => _driver.FindElement(By.XPath("//span[@id='layer_cart_product_title']"));

        public IWebElement DressQuantityBeforeCheckout => _driver.FindElement(By.XPath("//span[@id='layer_cart_product_quantity']"));

        public IWebElement DressColorAndSizeBeforeCheckout => _driver.FindElement(By.XPath("//span[@id='layer_cart_product_attributes']"));

        public IWebElement DressPriceBeforeCheckout => _driver.FindElement(By.XPath("//span[@id='layer_cart_product_price']"));

        public IWebElement ProductSuccesfullyAdded => _driver.FindElement(By.XPath("//i[@class='icon-ok']/following::text()[1]"));

        public IWebElement ContinueShoppingButton => _driver.FindElement(By.XPath("//span[@title='Continue shopping']"));

        public IWebElement QuickViewButtonPrintedDress => 
            _driver.FindElement(By.XPath("(//a[@class='product-name' and @title='Printed Dress']//parent::h5//parent::div//preceding-sibling::div//a/span)[1]"));

        public IWebElement HoverOverDressPicturePrintedDress => 
            _driver.FindElement(By.XPath("(//a[@class='product-name' and @title='Printed Dress'])[1]"));

        public IWebElement QuickViewButtonPrintedSummerDress => 
            _driver.FindElement(By.XPath("(//a[@class='product-name' and @title='Printed Summer Dress']//parent::h5//parent::div//preceding-sibling::div//a/span)[1]"));

        public IWebElement HoverOverDressPicturePrintedSummerDress => 
            _driver.FindElement(By.XPath("(//a[@class='product-name' and @title='Printed Summer Dress'])[1]"));

        public IWebElement QuickViewButtonPrintedChiffonDress =>
            _driver.FindElement(By.XPath("(//a[@class='product-name' and @title='Printed Chiffon Dress']//parent::h5//parent::div//preceding-sibling::div//a/span)[1]"));

        public IWebElement HoverOverDressPicturePrintedChiffonDress =>
            _driver.FindElement(By.XPath("(//a[@class='product-name' and @title='Printed Chiffon Dress'])[1]"));
    }
}

