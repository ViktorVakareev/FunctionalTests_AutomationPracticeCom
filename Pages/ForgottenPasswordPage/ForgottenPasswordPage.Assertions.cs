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
    }
}
