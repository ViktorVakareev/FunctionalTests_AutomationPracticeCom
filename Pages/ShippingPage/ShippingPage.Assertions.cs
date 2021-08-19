using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ShippingPage
    {
        public void AssertAddressesCartPageLoaded()
        {
            Assert.AreEqual("SHIPPING", ShippingPageHeading.Text);  
        }
    }
}
