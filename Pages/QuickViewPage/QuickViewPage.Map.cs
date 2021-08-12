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
        public IWebElement QuantityTextBox => _driver.FindElement(By.Id("quantity_wanted"));

        public IWebElement QuantityPlusButton => _driver.FindElement(By.XPath("//i[@class='icon-plus']"));

        public IWebElement SizeDropDown => _driver.FindElement(By.XPath("//div[@id='uniform-group_1']"));
          
        public IWebElement ColorSelectButton => _driver.FindElement(By.XPath("//ul[@id='color_to_pick_list']/li[@class='selected']"));                

        public IWebElement AddToCartButton => _driver.FindElement(By.XPath("//*[@id='add_to_cart']/button/span"));

        public IWebElement DressName => _driver.FindElement(By.XPath("//h1[contains(text(),'Printed Dress')]"));

        public IWebElement DressPrice => _driver.FindElement(By.Id("our_price_display"));
        // public IWebElement DressPrice => _driver.FindElement(By.XPath("//span[@id='our_price_display')]"));

        public IWebElement DressInfoText => _driver.FindElement(By.Id("short_description_content"));

        public IWebElement ProductSuccesfullyAdded => _driver.FindElement(By.XPath("//i[@class='icon-ok']/following::text()[1]"));

        // After Product successfully added to your shopping cart -- Before Checkout
        public IWebElement DressNameBeforeCheckout => _driver.FindElement(By.XPath("//span[@title='Continue shopping']"));

        public IWebElement DressQuantityBeforeCheckout => _driver.FindElement(By.Id("layer_cart_product_quantity"));        

        public IWebElement DressSizeAndColorBeforeCheckout => _driver.FindElement(By.Id("layer_cart_product_attributes"));

        public IWebElement DressPriceBeforeCheckout => _driver.FindElement(By.Id("layer_cart_product_price"));


    }
}
