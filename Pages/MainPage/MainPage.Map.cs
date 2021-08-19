using FunctionalTests_AutomationPracticeCom.Pages;
using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class MainPage //: Base
    {        
        public IWebElement QuickViewIframeWindow => _driver.FindElement(By.XPath("//iframe[@class='fancybox-iframe']"));

        public IWebElement ViewMyShoppingCartLink => _driver.FindElement(By.XPath("//a[@title='View my shopping cart']"));

        public IWebElement CompareButton => _driver.FindElement(By.XPath("(//form[@class='compare-form']/button[@type='submit'])[1]"));

        public IWebElement CartCheckoutButton => _driver.FindElement(By.XPath("//a[@id='button_order_cart']"));

        public IWebElement DressNameBeforeCheckout => _driver.FindElement(By.XPath("//span[@id='layer_cart_product_title']"));

        public IWebElement DressQuantityBeforeCheckout => _driver.FindElement(By.XPath("//span[@id='layer_cart_product_quantity']"));

        public IWebElement DressColorAndSizeBeforeCheckout => _driver.FindElement(By.XPath("//span[@id='layer_cart_product_attributes']"));

        public IWebElement DressPriceBeforeCheckout => _driver.FindElement(By.XPath("//span[@id='layer_cart_product_price']"));

        public IWebElement ProductSuccesfullyAdded => _driver.FindElement(By.XPath("//i[@class='icon-ok']/following::text()[1]"));

        public IWebElement ContinueShoppingButton => _driver.FindElement(By.XPath("//span[@title='Continue shopping']"));

        public IWebElement ErrorMessageProductComparison => _driver.FindElement(By.XPath("//p[@class='fancybox-error']"));

        public By ValidationMessageForSuccessfullyAddedToCart => By.XPath("//i[@class='icon-ok']");

        public By CompareButtonLocator => By.XPath("(//form[@class='compare-form']/button[@type='submit'])[1]");

        public IWebElement HoverDressByNameSpan(string dressName)
        {
            return _driver.FindElement(By.XPath($"//div[@class='right-block']//a[@class='product-name' and @title='{dressName}']"));
        }

        public IWebElement HoverDressByNameSpan(string dressName, string type)
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

        public IWebElement ProceedToCheckoutButton => _driver.FindElement(By.XPath("(//a[@title='Proceed to checkout'])[1]"));
        
        public IWebElement TotalCostFieldBeforeCheckout => _driver.FindElement(By.XPath("//span[@class='ajax_block_cart_total']"));
    }
}

