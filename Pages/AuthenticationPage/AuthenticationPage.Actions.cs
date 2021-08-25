using FunctionalTests_AutomationPracticeCom.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class AuthenticationPage : BasePage
    {
        public override string Url => "http://automationpractice.com/index.php?id_category=8&controller=category";

        public AuthenticationPage(IWebDriver driver) : base(driver)
        {        
        }
         
        public void ClickCreateAccount() 
        {
            CreateAccountButton.Click();
        }        
        
        public void ClickSignIn() 
        {
            SignInButton.Click();
        }

        public void ClickForgottenPasswordLink() 
        {
            ForgottenPasswordLink.Click();
        }        
    }
}
