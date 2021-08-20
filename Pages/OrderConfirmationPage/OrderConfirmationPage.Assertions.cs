using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class OrderConfirmationPage
    {
        public void AssertOrderIsSuccessfullyCompleted()
        {
            Assert.AreEqual("ORDER CONFIRMATION", OrderConfirmationPageHeading.Text);
            Assert.AreEqual("Your order on My Store is complete.", OrderCompletedMessage.Text);
        }
    }
}
