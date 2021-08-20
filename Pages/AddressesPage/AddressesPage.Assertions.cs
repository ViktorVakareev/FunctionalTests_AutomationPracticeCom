using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class AddressesPage
    {
        public void AssertAddressesPageLoaded()
        {
            Assert.AreEqual("ADDRESSES", AddressesPageHeading.Text);  
        }

        public void AssertCreateNewAccountSuccessful(PersonalInfo expectedPersonalInfo, AddressInfo expectedAddressInfo)
        {
            string expectedName = $"{expectedPersonalInfo.FirstName} {expectedPersonalInfo.LastName}";
            string expectedCityStateZip = $"{expectedAddressInfo.City}, {expectedAddressInfo.State} {expectedAddressInfo.Zip}";

            Assert.AreEqual(expectedName, DeliveryAddressNameField);      // first last
            Assert.AreEqual(expectedAddressInfo.Address, DeliveryAddress_AddressField);       // address
            Assert.AreEqual(expectedCityStateZip, DeliveryAddressCityStateZipField);      // city, state zip
            Assert.AreEqual(expectedAddressInfo.Country, DeliveryAddressCountryField);       // country
            Assert.AreEqual(expectedAddressInfo.MobilePhone, DeliveryAddressMobilePhoneField.Text);       //mobile
        }
    }
}
