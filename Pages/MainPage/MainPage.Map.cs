﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class MainPage
    {
        public IWebElement QuickViewIframeWindow => _driver.FindElement(By.XPath("//iframe[@class='fancybox-iframe']"));

        public IWebElement CompareButton => _driver.FindElement(By.XPath("(//form[@class='compare-form']/button[@type='submit'])[1]"));

        public IWebElement DressNameBeforeCheckout => _driver.FindElement(By.XPath("//span[@id='layer_cart_product_title']"));

        public IWebElement DressQuantityBeforeCheckout => _driver.FindElement(By.XPath("//span[@id='layer_cart_product_quantity']"));

        public IWebElement DressColorAndSizeBeforeCheckout => _driver.FindElement(By.XPath("//span[@id='layer_cart_product_attributes']"));

        public IWebElement DressPriceBeforeCheckout => _driver.FindElement(By.XPath("//span[@id='layer_cart_product_price']"));

        public IWebElement ProductSuccesfullyAdded => _driver.FindElement(By.XPath("//i[@class='icon-ok']/following::text()[1]"));

        public IWebElement ContinueShoppingButton => _driver.FindElement(By.XPath("//span[@title='Continue shopping']"));

        public IWebElement ErrorMessageProductComparison => _driver.FindElement(By.XPath("//p[@class='fancybox-error']"));

        public By ValidationMessageForSuccessfullyAddedToCart => By.XPath("//i[@class='icon-ok']");

        public IWebElement HoverDressByName(string dressName)
        {
            return _driver.FindElement(By.XPath($"//div[@class='right-block']//a[@class='product-name' and @title='{dressName}']"));
        }

        public IWebElement HoverDressByName(string dressName, string type)
        {
            return _driver.FindElement(By.XPath($"(//div[@class='right-block']//a[@class='product-name' and @title='{dressName}'])[{type}]"));
        }

        public IWebElement QuickViewButtonDressByName(string dressName)
        {
            return _driver.FindElement(By.XPath($"//a[@class='product-name' and @title='{dressName}']//parent::h5//parent::div//preceding-sibling::div//a/span[contains(text(),'Quick')]"));
        }

        public IWebElement AddToCompareButtonDressByName(string dressName, int productId)  // productID -> 3, 4, 5, 6, 7
        {
            return _driver.FindElement(By.XPath($"//a[@class='product-name' and @title='{dressName}']//following::a[@class='add_to_compare' and @data-id-product='{productId}']"));
        }               
    }
}

