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
    }
}
