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

        public void AssertDeliveryPriceIsRightAmount()
        {
            var orderDressInfo = new OrderDressInfo();
            Assert.AreEqual(orderDressInfo.DeliveryPrice, ShippingDeliveryPriceField.Text);
        }

        public void AssertReadTheTermsLinkFollowed()
        {
            Assert.AreEqual("TERMS AND CONDITIONS OF USE", ReadTheTermsPageHeading.Text);
        }

        public void AssertAgreeToTermsErrorMessage()
        {
            Assert.AreEqual("You must agree to the terms of service before continuing.", AgreeToTermsErrorMessage.Text);
        }
    }
}
