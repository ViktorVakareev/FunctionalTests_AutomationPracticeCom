namespace FunctionalTests_AutomationPracticeCom
{
    public class QuickViewPageFacade
    {
        private MainPage _mainPage;
        private QuickViewPage _quickViewPage;

        public QuickViewPageFacade(MainPage mainPage, QuickViewPage quickViewPage)
        {
            _mainPage = mainPage;
            _quickViewPage = quickViewPage;
        }

        [System.Obsolete]
        public void Open(string dressName) 
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.ClickAddToCart();
            _mainPage.WaitUntilProductIsAddeToCart();
        }

        [System.Obsolete]
        public void Open(string dressName, OrderDressInfo order)
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage("Printed Chiffon Dress");
            _quickViewPage.AddOrderToCart(order);
            _mainPage.WaitUntilProductIsAddeToCart();
        }
    }
}
