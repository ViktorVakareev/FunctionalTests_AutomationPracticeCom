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
        
        public void AssertInvalidEmailMessage()
        {
            Assert.AreEqual("Invalid email address.", InvalidEmailMessage.Text);
        }
    }
}
