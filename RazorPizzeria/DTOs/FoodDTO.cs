namespace RazorPizzeria.DTOs
{
    public class FoodDTO
    {
        public int Id { get; set; }
        public string Food { get; set; } = default!;
        public bool IsGlutenFree { get; set; }
        public string Size { get; set; } = default!;
        public string Category { get; set; } = default!;
        public decimal Price { get; set; }
    }
}
