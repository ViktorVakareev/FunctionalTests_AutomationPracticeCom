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
        public string Url => "http://automationpractice.com/index.php?controller=authentication";

        public AuthenticationPage(IWebDriver driver) : base(driver)
        {        
        }
         
        public void ClickCreateAccount()
        {
            CreateAccountButton.Click(); ;
        } 
        
        public void ClickSignIn()
        {
            SignInButton.Click(); ;
        }
    }
}
