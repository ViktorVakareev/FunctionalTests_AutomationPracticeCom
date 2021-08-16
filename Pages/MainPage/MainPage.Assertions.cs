using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class MainPage
    {

        public void AssertValidDressName(OrderDressInfo expectedDressInfo)
        {
            Assert.AreEqual(expectedDressInfo.DressName, DressNameBeforeCheckout.Text);
            Assert.AreEqual(expectedDressInfo.Quantity, DressQuantityBeforeCheckout.Text);
            Assert.AreEqual(expectedDressInfo.ColorAndSize, DressColorAndSizeBeforeCheckout.Text);
            Assert.AreEqual(expectedDressInfo.Price, DressPriceBeforeCheckout.Text);
        }       
    }
}
