using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class OrderSummaryPage
    {
        public void AssertOrderSummaryPageLoaded()
        {
            Assert.AreEqual("ORDER SUMMARY", OrderSummaryPageHeading.Text);  
        }

        public void AssertOrderSummaryBankWirePaymentPageLoaded()
        {
            Assert.AreEqual("BANK-WIRE PAYMENT.", OrderSummaryPageSubHeading.Text);
        }

        public void AssertOrderSummaryCheckPaymentPageLoaded()
        {
            Assert.AreEqual("CHECK PAYMENT", OrderSummaryPageSubHeading.Text);
        }
    }
}
