using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class QuickViewPage
    {
        public QuickViewPage()
        {
        }
             public void AssertQuickViewPageNavigationToPrintedDress(string dressName)
        {
            Assert.AreEqual(dressName, PrintedDressNameTextFieldInQuickView.Text);
        }

        public void AssertQuickViewPageNavigationToPrintedSummerDress(string dressName)
        {
            Assert.AreEqual(dressName, PrintedSummerDressNameTextFieldInQuickView.Text);
        }

        public void AssertQuickViewPageNavigationToPrintedChiffonDress(string dressName)
        {
            Assert.AreEqual(dressName, PrintedChiffonDressNameTextFieldInQuickView.Text);
        }
        //public void AssertValidDressName_When_EnteringQuickView()
        //{
        //    Assert.AreEqual("Printed Dress", DressName.Text);
        //}
        //public void AssertValidDressQuantity_When_EnteringQuickView()
        //{
        //    Assert.AreEqual("1", QuantityTextBox.Text);
        //}

        //public void AssertValidDressPrice_When_EnteringQuickView()
        //{
        //    Assert.AreEqual("$26.00", DressPrice.Text);
        //}

        //public void AssertValidDressSize_When_EnteringQuickView()
        //{
        //    Assert.AreEqual("S", SelectedSize.Text);
        //}

        //public void AssertValidDressInfoText_When_EnteringQuickView()
        //{
        //    Assert.AreEqual("100% cotton double printed dress. Black and white striped top and orange high waisted skater skirt bottom.", DressInfoText.Text);
        //}        
    }
}
