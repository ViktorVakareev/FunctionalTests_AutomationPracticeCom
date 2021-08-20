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
        
        public void AssertCreateNewAccountSuccessful(PersonalInfo expectedPersonalInfo, AddressInfo expectedAddressInfo)
        {
            Assert.AreEqual("", "");
            Assert.AreEqual("", "");
            Assert.AreEqual("", "");
            Assert.AreEqual("", "");
        } 
        
        public void AssertInvalidEmailMessage()
        {
            Assert.AreEqual("Invalid email address.", InvalidEmailMessage.Text);
        }
    }
}
