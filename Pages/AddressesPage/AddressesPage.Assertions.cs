using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class AddressesPage
    {
        public void AssertAddressesCartPageLoaded()
        {
            Assert.AreEqual("ADDRESSES", AddressesPageHeading.Text);  
        }

       
    }
}
