using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class AuthenticationPage
    {
        public void AssertAuthenticationPageLoaded()
        {
            Assert.AreEqual("AUTHENTICATION", AuthenticationPageHeading.Text);
        }              
        
        public void AssertValidationMessage(string expectedValidationMessage)
        {
            Assert.AreEqual(expectedValidationMessage, ValidationMessage(expectedValidationMessage).Text);
        }       
    }
}
