using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class MyAccountPage
    {
        public void AssertMyAccountPageLoaded()
        {
            Assert.AreEqual("MY ACCOUNT", MyAccountPageHeading.Text);  
        }
    }
}
