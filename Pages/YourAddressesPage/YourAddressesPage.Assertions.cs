using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class YourAddressesPage
    {
        public void AssertYourAddressesPageLoaded()
        {
            Assert.AreEqual("YOUR ADDRESSES", YourAddressesPageHeading.Text);
        }       
    }
}
