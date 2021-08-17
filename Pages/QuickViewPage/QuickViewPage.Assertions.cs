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
             public void AssertQuickViewPageNavigationToProduct(string dressName)
        {
            Assert.AreEqual(dressName, DressNameTextFieldInQuickView(dressName).Text);
        }
  
    }
}
