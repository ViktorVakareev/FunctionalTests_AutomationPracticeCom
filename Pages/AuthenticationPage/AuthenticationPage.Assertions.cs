using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class AuthenticationPage
    {
        public void AssertShppoingCartPageLoaded()
        {
            Assert.AreEqual("AUTHENTICATION", AuthenticationPageHeading.Text);  
        }

       
    }
}
