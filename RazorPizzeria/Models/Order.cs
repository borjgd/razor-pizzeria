namespace RazorPizzeria.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string ClientName { get; set; } = default!;
        public string ClientAddress { get; set; } = default!;
        public string ClientTlfNumber { get; set; } = default!;
        public DateTime OrderDate { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; } = default!;

    }
}
