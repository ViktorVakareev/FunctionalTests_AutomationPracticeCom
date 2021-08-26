namespace FunctionalTests_AutomationPracticeCom
{
    public class OrderDressInfo
    {
        public OrderDressInfo()
        {                
        }

        public OrderDressInfo(string dressName, string color, string size, int quantity, string price)
        {
            this.DressName = dressName;
            this.Color = color;
            this.Size = size;
            this.Quantity = quantity;
            this.Price = price;
        }

        private readonly string deliveryPrice = "$2.00";

        public string DressName { get; set; }

        public string Color { get; set; }   // Color, Size( ex. "Orange, S")

        public string Size { get; set; }

        public int Quantity { get; set; }

        public string Price { get; set; }

        public string DeliveryPrice => this.deliveryPrice;
    }
}
