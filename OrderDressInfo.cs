namespace FunctionalTests_AutomationPracticeCom
{
    public class OrderDressInfo
    {
        private readonly string deliveryPrice = "$2.00";

        public string DressName { get; set; }

        public string Color { get; set; }   // Color, Size( ex. "Orange, S")

        public string Size { get; set; }   

        public int Quantity { get; set; }  

        public string Price { get; set; }

        public string DeliveryPrice => this.deliveryPrice;
    }
}
