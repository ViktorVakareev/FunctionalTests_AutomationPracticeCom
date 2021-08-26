namespace FunctionalTests_AutomationPracticeCom
{
    public class Facade
    {
        private MainPage _mainPage;
        private QuickViewPage _quickViewPage;

        public Facade(MainPage mainPage, QuickViewPage quickViewPage)
        {
            _mainPage = mainPage;
            _quickViewPage = quickViewPage;
        }

        [System.Obsolete]
        public void OpenQuickViewPage(string dressName) 
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage(dressName);
            _quickViewPage.ClickAddToCart();
            _mainPage.WaitUntilProductIsAddeToCart();
        }

        [System.Obsolete]
        public void OpenQuickViewPage(string dressName, OrderDressInfo order)
        {
            _mainPage.Open();
            _mainPage.OpenQuickViewPage(dressName);
            _quickViewPage.AddOrderToCart(order);
            _mainPage.WaitUntilProductIsAddeToCart();
        }
    }
}
