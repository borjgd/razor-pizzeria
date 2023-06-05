namespace RazorPizzeria.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int FoodItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Order Order { get; set; } = default!;
        public FoodItems FoodItem { get; set; } = default!;
    }
}
