using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public partial class FunctionalTests
    {
        [Test]
        [Obsolete]
        public void OpenShoppingCartPage_When_ClickingCheckoutButtonFromCart()
        {
            var expectedDressInfo = new OrderDressInfo()
            {
                DressName = "Printed Dress",
                Color = "Orange",
                Size = "L",
                Quantity = 3,
                Price = "$26.00"
            };

            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Dress");
            _quickViewPage.ClickAddToCart();
            _mainPage.WaitUntilProductIsAddeToCart();
            _mainPage.ClickContinueShoppingButton();
            _mainPage.ClickCartCheckoutButton();

            _shoppingCartPage.AssertShoppingCartPageLoaded();
        }
    }
}


