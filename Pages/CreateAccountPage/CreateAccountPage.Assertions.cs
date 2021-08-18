using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class CreateAccountPage
    {
        public void AssertCreateAccountCartPageLoaded()
        {
            Assert.AreEqual("CREATE AN ACCOUNT", CreateAccountPageHeading.Text);  
        }       
    }
}
