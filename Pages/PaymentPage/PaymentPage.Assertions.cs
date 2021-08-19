using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class PaymentPage
    {
        public void AssertPaymentPageLoaded()
        {
            Assert.AreEqual("PLEASE CHOOSE YOUR PAYMENT METHOD", PaymentPageHeading.Text);  
        }

       
    }
}
