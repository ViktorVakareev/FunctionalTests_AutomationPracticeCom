using OpenQA.Selenium;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class ForgottenPasswordPage
    {      
        public IWebElement RetrievePasswordButton => _driver.FindElement(By.XPath("//p[@class='submit']/button"));

        public IWebElement EmailInputField => _driver.FindElement(By.XPath("//input[@id='email']"));

        public IWebElement BackToLoginLink => _driver.FindElement(By.XPath("//a[@title='Back to Login']")); 
        
        public IWebElement ForgottenPasswordEmailErrorValidationMessage => _driver.FindElement(By.XPath("//li[contains(text(),'There is no account registered for this email address.')]"));    
        
        public IWebElement ForgottenPasswordEmailConfirmationMessage => _driver.FindElement(By.XPath("//p[@class='alert alert-success']"));         
        
        public IWebElement ForgottenPasswordPageHeading => _driver.FindElement(By.XPath("//h1[@class='page-subheading']"));                  
    }
}

