namespace BlueModasApi.Models {
    public class SaleItem {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Sale Sale { get; set; }
    }
}