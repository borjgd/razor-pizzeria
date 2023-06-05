namespace RazorPizzeria.Models
{
    public class FoodItems
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public decimal price { get; set; }

        public int FoodCategoryId { get; set; }
        public FoodCategories FoodCategory { get; set; } = default!;
    }
}
