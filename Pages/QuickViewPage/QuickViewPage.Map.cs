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

        public IWebElement PrintedDressIncreaseQuantityButtonInQuickView => 
            _driver.FindElement(By.XPath("(//h1[contains(text(),'Printed Dress')]//following::form//following::p//following::a/span)[2]"));

        public IWebElement PrintedSummerDressIncreaseQuantityButtonInQuickView =>
          _driver.FindElement(By.XPath("(//h1[contains(text(),'Printed Summer Dress')]//following::form//following::p//following::a/span)[2]"));

        public IWebElement PrintedChiffonDressIncreaseQuantityButtonInQuickView =>
          _driver.FindElement(By.XPath("(//h1[contains(text(),'Printed Chiffon Dress')]//following::form//following::p//following::a/span)[2]"));
                
        public IWebElement PrintedSummerDressSelectColorButtonInQuickView =>
          _driver.FindElement(By.XPath("//h1[contains(text(),'Printed Summer Dress')]//following::form//following::p//following::ul//a[@name='Blue']"));

        public IWebElement PrintedChiffonDressSelectColorButtonInQuickView =>
          _driver.FindElement(By.XPath("//h1[contains(text(),'Printed Chiffon Dress')]//following::form//following::p//following::ul//a[@name='Green']"));

        public IWebElement PrintedDressSizeDropDownButtonInQuickView =>
           _driver.FindElement(By.XPath("//h1[contains(text(),'Printed Dress')]//following::form//following::p//following::div[@class='selector']"));

        public IWebElement PrintedSummerDressSizeDropDownButtonInQuickView =>
          _driver.FindElement(By.XPath("//h1[contains(text(),'Printed Summer Dress')]//following::form//following::p//following::div[@class='selector']"));

        public IWebElement PrintedChiffonDressSizeDropDownButtonInQuickView =>
         _driver.FindElement(By.XPath("//h1[contains(text(),'Printed Chiffon Dress')]//following::form//following::p//following::div[@class='selector']//following::select"));  
    }
}

