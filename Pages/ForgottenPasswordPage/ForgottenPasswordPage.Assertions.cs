using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ForgottenPasswordPage
    {
        public void AssertForgottenPasswordPageLoaded()
        {
            Assert.AreEqual("FORGOT YOUR PASSWORD?", ForgottenPasswordPageHeading.Text);  
        }

        public void AssertRetriveForgottenPasswordErrorMessage()
        {
            Assert.AreEqual("There is no account registered for this email address.", ForgottenPasswordEmailErrorValidationMessage.Text);
        }

        public void AssertRetriveForgottenPasswordConfirmationMessage(string expectedValidEmail)
        {
            Assert.AreEqual($"A confirmation email has been sent to your address: {expectedValidEmail}", ForgottenPasswordEmailConfirmationMessage.Text);
        }
    }
}
