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
    public partial class CreateAccountPage : BasePage
    {
        public override string Url => "http://automationpractice.com/index.php?id_category=8&controller=category";

        public CreateAccountPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickRegisterButton() => RegisterButton.Click();

        public void FillInNewAccountInfo(PersonalInfo personalInfo, AddressInfo addressInfo)
        {
        //    Title = "Mr.",
        //        FirstName = "Jimmy",
        //        LastName = "Fallon",
        //        Email = newEmail,
        //        Password = newPassword,
        //        DateOfBirth = dateOfBirth


        //var addressInfo = new AddressInfo()


        //    FirstName = "Jimmy",
        //    LastName = "Fallon",
        //    Address = "22, Jump Street",
        //    City = "Tom's River",
        //    State = "New Jersey",
        //    Zip = "08751",
        //    Country = "United States",
        //    MobilePhone = "222555888",
        //    AddressAlias = "Jimmy's Home",
        }
    }
}
