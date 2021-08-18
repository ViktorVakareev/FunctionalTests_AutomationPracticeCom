using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class CreateAccountPage
    {
        public IWebElement RegisterButton => _driver.FindElement(By.Id("submitAccount"));

        public IWebElement SignInButton => _driver.FindElement(By.Id("")); 
        
        public IWebElement EmailCreateAccountTextBox => _driver.FindElement(By.Id(""));    

        public IWebElement EmailSignInTextBox => _driver.FindElement(By.Id(""));     
        
        public IWebElement PasswordSignInBox => _driver.FindElement(By.Id(""));   
        
        public IWebElement ForgottenPasswordLink => _driver.FindElement(By.LinkText(""));  

        public IWebElement SummarySectionLink => _driver.FindElement(By.LinkText("Summary"));  
        
        public IWebElement CreateAccountPageHeading => _driver.FindElement(By.XPath("//h1[@class='page-heading']"));          
    }
}

