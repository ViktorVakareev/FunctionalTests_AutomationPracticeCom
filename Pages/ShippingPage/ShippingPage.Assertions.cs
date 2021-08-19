using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ShippingPage
    {
        public void AssertShippingPageLoaded()
        {
            Assert.AreEqual("SHIPPING", ShippingPageHeading.Text);  
        }
    }
}
