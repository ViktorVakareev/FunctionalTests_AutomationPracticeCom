using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ShoppingCartPage
    {
        public IWebElement ProceedToCheckoutButton => _driver.FindElement(By.XPath("(//a[@title='Proceed to checkout'])[2]"));

        public IWebElement TotalPriceField => _driver.FindElement(By.XPath("//span[@id='total_price']")); 
        
        public IWebElement ColorAndSizeField => _driver.FindElement(By.XPath("//small[@class='cart_ref']//following-sibling::small/a"));    // Color : Beige, Size : S

        public IWebElement UnitPriceField => _driver.FindElement(By.XPath("//td[@data-title='Unit price']//following::span[@class='price']/span"));     
        
        public IWebElement QuantityField => _driver.FindElement(By.XPath("(//td[@class='cart_quantity text-center']//following::input[@type='text'])[1]"));   
        
        public IWebElement DressNameField => _driver.FindElement(By.XPath("//td[@class='cart_description']//following::p[@class='product-name']/a"));              
    }
}

