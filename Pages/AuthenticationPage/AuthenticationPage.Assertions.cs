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

        public void AssertSignInSuccessful()
        {
            Assert.AreEqual("", SuccessfulSignIn.Text);
        }

        public void AssertSignInErrorMessage()
        {
            Assert.AreEqual("", UnsuccessfulSignInMessage.Text);
        }
    }
}
