using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class AuthenticationPage
    {
        public IWebElement CreateAccountButton => _driver.FindElement(By.Id("SubmitCreate"));

        public IWebElement SignInButton => _driver.FindElement(By.Id("SubmitLogin")); 
        
        public IWebElement EmailCreateAccountBox => _driver.FindElement(By.Id("email_create"));    

        public IWebElement EmailSignInTextBox => _driver.FindElement(By.Id("email"));     
        
        public IWebElement PasswordSignInTextBox => _driver.FindElement(By.Id("passwd"));   
        
        public IWebElement ForgottenPasswordLink => _driver.FindElement(By.LinkText("Forgot your password?"));  

        public IWebElement SummarySectionLink => _driver.FindElement(By.LinkText("Summary"));  
        
        public IWebElement AuthenticationPageHeading => _driver.FindElement(By.XPath("//h1[@class='page-heading']"));          
    }
}

